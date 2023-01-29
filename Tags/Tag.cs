﻿using RainState.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RainState.Tags
{
    public abstract class Tag
    {
        static Dictionary<string, string> TagSpecificIds = new()
        {
            ["WINSTATE"] = "ws",
        };

        static HashSet<string> TagLoadAsStringTag = new()
        {
            "VISITED"
        };

        public virtual string DisplayName { get => Name; }
        public abstract string Name { get; set; }
        public string TagId;
        public Tag? Parent;

        internal TreeNode? TreeNode { get; private set; }

        public Tag(string id)
        {
            TagId = id;
        }

        public TreeNode CreateTreeNode(bool readOnly)
        {
            if (readOnly)
                return CreateTreeNodeInternal(true);

            return TreeNode = CreateTreeNodeInternal(false);
        }

        public abstract void Serialize(StringBuilder builder);
        protected abstract TreeNode CreateTreeNodeInternal(bool readOnly);
        public abstract T? GetTag<T>(string tagId, string name, bool create, string[]? filters) where T : Tag;

        public virtual bool TryConvert<T>(out T newTag) where T : Tag
        {
            newTag = default!;
            return false;
        }
        protected virtual void ChildNameChanged(Tag child, string name) { }

        protected void NameChanged()
        {
            Parent?.ChildNameChanged(this, Name);
        }
        protected void Changed()
        {
            MainForm.Instance.TagChanged(this);
        }

        // progDiv@MISCPROG/mpd$/mpd@MENUREGION/#
        public Tag? QueryTag(string query, bool create = true)
        {
            Tag? tag = this;

            foreach (TagQueryElement tagelement in new TagQueryPathEnumerator(query))
            {
                if (tag is null)
                    return null;

                tag = tagelement.Type switch
                {
                    TagType.Pair =>  tag.GetTag<KeyValueTag>(tagelement.Id, tagelement.Name, create, tagelement.Filters),
                    TagType.List =>  tag.GetTag<ListTag>    (tagelement.Id, tagelement.Name, create, tagelement.Filters),
                    TagType.Value => tag.GetTag<ValueTag>   (tagelement.Id, tagelement.Name, create, tagelement.Filters),
                    _ => throw new InvalidDataException($"Invalid tag type from query enumerator: {tagelement.Type}")
                };
            }

            return tag;
        }

        public Tag GetParent(int level)
        {
            int parents = 0;
            Tag tag = this;
            while (tag.Parent is not null)
            {
                tag = tag.Parent;
                parents++;
            }

            int targetParent = parents - level;
            tag = this;
            while (targetParent > 0 && tag.Parent is not null)
                tag = tag.Parent;

            return tag;
        }

        public bool MatchQuery(ReadOnlySpan<TagQueryElement> path, bool searchMatchingParent = true)
        {
            if (path.IsEmpty)
                return true;

            while (!path.IsEmpty)
            {
                TagQueryElement element = path[^1];
                bool type = element.Type switch
                {
                    TagType.Pair => this is KeyValueTag,
                    TagType.List => this is ListTag,
                    TagType.Value => this is ValueTag,
                    _ => false
                };
                if (!type || element.Name != "" && element.Name != Name || TagId != "" && element.Id != TagId)
                {
                    if (!searchMatchingParent)
                        return false;
                    break;
                }
                searchMatchingParent = false;

                break;
            }

            if (path.IsEmpty)
                return false;

            return Parent?.MatchQuery(path[..^1], searchMatchingParent) ?? !searchMatchingParent;
        }

        public bool MatchFilters(string[] filters, bool create = false)
        {
            foreach (string filter in filters)
                if (QueryTag(filter, create) is null)
                    return false;
            return true;
        }

        public static T Convert<T>(Tag? parent, Tag? tag, string tagId, string name) where T : Tag
        {
            if (tag is not null && tag.TryConvert(out T newTag))
                return newTag;

            newTag = (T)Activator.CreateInstance(typeof(T))!;

            newTag.Parent = parent;
            newTag.TagId = tagId;
            newTag.Name = name;
            return newTag;
        }

        public static Tag? ReadTag(string str, int start)
        {
            return ReadTag(str, ref start, str.Length, null);
        }

        public static Tag? ReadTag(string str, ref int pos, int end, string? currentTagId)
        {
            if (pos == end)
                return null;
            if (FindNextTag(str, pos, end, currentTagId, out string? id))
            {
                // A, ListSeparator
                // Key<B>Value<A>Key<B>Value<A>

                // B, NameValueDelimeter
                // Key<B>Value<A>Key<B>Value<A>

                // C, TagListSeparator
                // Key<xB>Value1.1<yA>Value1.2<xC>Value2.1<yA>Value2.2<xA>

                // D, KeyValueDelimeter
                // Key<B>user string 1<D>user value<C>user string 2<D>user value<A>

                for (char c = 'A'; c <= 'D'; c++)
                {
                    string tagString = $"<{id}{c}>";
                    int index = str.IndexOf(tagString, pos, end - pos);

                    if (index >= 0)
                        return ReadTypedTag(str, ref pos, end, c, id, tagString, index);

                }
            }

            return new ValueTag(str.Substring(pos, end - pos));
        }

        static Tag ReadTypedTag(string str, ref int pos, int end, char type, string tagId, string tagString, int tagStringPos)
        {
            switch (type)
            {
                case 'A':
                case 'C':
                    List<Tag?> tags = new();

                    while (pos < end)
                    {
                        int index = str.IndexOf(tagString, pos, end - pos);
                        int valueEnd = index < 0 ? end : index;
                        tags.Add(ReadTag(str, ref pos, valueEnd, tagId));
                        pos = index < 0 ? end : index + tagString.Length;
                    }

                    return new ListTag(tagId, type == 'C', tags);

                case 'B':
                case 'D':
                    string name = str.Substring(pos, tagStringPos - pos);

                    string valueTagId = tagId;
                    if (TagSpecificIds.TryGetValue(name, out string? tagSpecific))
                        valueTagId = tagSpecific;

                    pos = tagStringPos + tagString.Length;
                    Tag? value;
                    if (TagLoadAsStringTag.Contains(name))
                        value = new ValueTag(str.Substring(pos, end - pos));
                    else
                        value = ReadTag(str, ref pos, end, valueTagId);

                    if (value is KeyValueTag { Alternative: true })
                        value = new ListTag(value.TagId, true, new[] { value });

                    return new KeyValueTag(tagId, type == 'D', name, value);

                default:
                    throw new InvalidDataException();
            }
        }

        static bool FindNextTag(string str, int pos, int end, string? currentTagId, [NotNullWhen(true)] out string? id)
        {
            if (currentTagId is not null)
            {
                int index = pos;
                while (true)
                {
                    index = str.IndexOf(currentTagId, index, end - pos);
                    if (index < 0)
                        break;

                    if (index > 0 && index < end - currentTagId.Length - 1 && str[index - 1] == '<' && str[index + currentTagId.Length + 1] == '>')
                    {
                        id = currentTagId;
                        return true;
                    }
                    index++;
                }
            }

            id = null;

            int lt = str.IndexOf('<', pos, end - pos);
            if (lt < 0)
                return false;
            int gt = str.IndexOf('>', lt, end - lt);
            if (gt < 0)
                return false;

            if (gt - 1 == lt)
                return false;
            
            id = str.Substring(lt + 1, gt - lt - 2);
            return true;
        }
    }
}
