﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace RainState.Tags
{
    public class ListTag : Tag
    {
        public ObservableCollection<Tag?> Tags;
        public bool Alternative;

        public override string Name { get => ""; set { } }

        public ListTag() : base("")
        {
            Tags = new();
            Tags.CollectionChanged += TagsChanged;
        }

        public ListTag(string id, bool alt, IEnumerable<Tag?> tags) : base(id)
        {
            Alternative = alt;
            Tags = new(tags);

            foreach (Tag? tag in Tags)
                if (tag is not null)
                    tag.Parent = this;

            Tags.CollectionChanged += TagsChanged;
        }

        private void TagsChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            if (TreeNode is null)
                return;

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (Tags[^1] is not null)
                    {
                        Tag tag = Tags[^1]!;
                        TreeNode tagNode = tag.CreateTreeNode();
                        AddContextMenus(tagNode, tag);
                        TreeNode.Nodes.Add(tagNode);
                    }
                    break;
            
                case NotifyCollectionChangedAction.Remove:
            
                    if (e.OldItems![0] is null)
                        return;
            
                    int index = e.OldStartingIndex;
                    for (int i = index; i >= 0; i--)
                        if (Tags[i] is null)
                            index--;
            
                    TreeNode.Nodes.RemoveAt(index);
                    break;
            
                case NotifyCollectionChangedAction.Replace:
                case NotifyCollectionChangedAction.Move:
                case NotifyCollectionChangedAction.Reset:
                    TreeNode.Nodes.Clear();
                    foreach (Tag? tag in Tags)
                        if (tag is not null)
                        {
                            TreeNode tagNode = tag.CreateTreeNode();
                            AddContextMenus(tagNode, tag);
                            TreeNode.Nodes.Add(tagNode);
                        }
            
                    break;
            }
        }

        public override void Serialize(StreamWriter writer)
        {
            for (int i = 0; i < Tags.Count; i++)
            {
                Tag? tag = Tags[i];
                tag?.Serialize(writer);

                writer.Write('<');
                writer.Write(TagId);
                writer.Write(Alternative ? 'C' : 'A');
                writer.Write('>');
            }
        }

        protected override TreeNode CreateTreeNodeInternal()
        {
            TreeNode node = new();

            foreach (Tag? tag in Tags)
                if (tag is not null)
                {
                    TreeNode tagNode = tag.CreateTreeNode();
                    AddContextMenus(tagNode, tag);
                    if (tag is ListTag list && tagNode.Text == "")
                        tagNode.Text = list.Tags.FirstOrDefault(t => t is not null)?.Name ?? "";
                    node.Nodes.Add(tagNode);
                }

            return node;
        }

        public override T GetTag<T>(string tagId, string name)
        {
            for (int i = 0; i < Tags.Count; i++)
            {
                Tag? tag = Tags[i];
                if (tag is null || tag.TagId != tagId)
                    continue;

                if (tag.Name != name)
                    continue;

                if (tag is T t)
                    return t;

                tag = Convert<T>(tag, tagId, name);
                Tags[i] = tag;
                return (T)tag;
            }

            T newTag = Convert<T>(null, tagId, name);
            Tags.Add(newTag);
            return newTag;
        }

        void AddContextMenus(TreeNode node, Tag tag)
        {
            node.ContextMenuStrip ??= new();

            node.ContextMenuStrip.Items.Add("Remove", null, (_, _) =>
            {
                Tags.Remove(tag);
            });
        }
    }
}
