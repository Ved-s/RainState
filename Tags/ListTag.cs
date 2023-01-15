using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            if (TreeNode is not TreeViewItem item)
                return;

            ItemCollection treeItems = item.Items;

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (Tags[^1] is not null)
                        treeItems.Add(Tags[^1]?.CreateTreeNode());
                    break;

                case NotifyCollectionChangedAction.Remove:

                    if (e.OldItems![0] is null)
                        return;

                    int index = e.OldStartingIndex;
                    for (int i = index; i >= 0; i--)
                        if (Tags[i] is null)
                            index--;

                    treeItems.Remove(index);
                    break;

                case NotifyCollectionChangedAction.Replace:
                case NotifyCollectionChangedAction.Move:
                case NotifyCollectionChangedAction.Reset:
                    treeItems.Clear();
                    foreach (Tag? tag in Tags)
                        if (tag is not null)
                            item.Items.Add(tag?.CreateTreeNode());

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

        protected override FrameworkElement CreateTreeNodeInternal()
        {
            TreeViewItem item = new();

            foreach (Tag? tag in Tags)
                if (tag is not null)
                    item.Items.Add(tag?.CreateTreeNode());

            if (Tags.Count > 0 && Tags[0] is ValueTag value)
            {
                item.Header = value.Value;
            }

            return item;
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
    }
}
