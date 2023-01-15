using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace RainState.Tags
{
    public abstract class Tag
    {
        static Dictionary<string, string> TagSpecificIds = new()
        {
            ["WINSTATE"] = "ws",
        };

        public abstract string Name { get; set; }
        public string TagId;
        public Tag? Parent;

        internal TreeNode TreeNode { get; private set; }

        public Tag(string id)
        {
            TagId = id;
        }

        public TreeNode CreateTreeNode()
        {
            return TreeNode = CreateTreeNodeInternal();
        }

        public abstract void Serialize(StreamWriter writer);
        protected abstract TreeNode CreateTreeNodeInternal();
        public abstract T GetTag<T>(string tagId, string name) where T : Tag;

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

        public static T Convert<T>(Tag? tag, string tagId, string name) where T : Tag
        {
            if (tag is not null && tag.TryConvert(out T newTag))
                return newTag;

            newTag = (T)Activator.CreateInstance(typeof(T))!;

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
                    Tag? value = ReadTag(str, ref pos, end, valueTagId);

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

            id = str.Substring(lt + 1, gt - lt - 2);
            return true;
        }

    }
}
