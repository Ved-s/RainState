using RainState.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace RainState.Tags
{
    public class KeyValueTag : Tag
    {
        private string key;

        public Tag? Value;
        public bool Alternative;

        public override string DisplayName 
        { 
            get 
            {
                if (Value is null || Value.DisplayName == "")
                {
                    if (Value is not null && Value.TagId != TagId)
                        return $"{Key} <{Value.TagId}> ";
                    return Key;
                }

                if (Value.TagId != TagId && Value.TagId != "")
                    return $"<{Value.TagId}> {Key}: {Value.DisplayName}";

                return $"{Key}: {Value.DisplayName}";
            }
        }
        public override string Name { get => Key; set => Key = value; }

        public string Key
        {
            get => key;
            set
            {
                key = value;
                UpdateNodeName();
                NameChanged();
            }
        }

        public string? StringValue 
        {
            get 
            {
                if (Value is ValueTag value)
                    return value.Value;
                else if (Value is KeyValueTag tag)
                    return tag.StringValue;
                return null;
            }
            set
            {
                if (value is null)
                    return;

                if (Value is ValueTag valuetag)
                    valuetag.Value = value;
                else if (Value is KeyValueTag tag)
                    tag.StringValue = value;
            }
        }

        public KeyValueTag() : base("")
        {
            key = "";
        }

        public KeyValueTag(string id, bool alt, string name, Tag? value) : base(id)
        {
            Alternative = alt;
            key = name;
            Value = value;
            if (Value is not null)
                Value.Parent = this;
        }

        public override void Serialize(StreamWriter writer)
        {
            writer.Write(Key);
            writer.Write('<');
            writer.Write(TagId);
            writer.Write(Alternative ? 'D' : 'B');
            writer.Write('>');
            Value?.Serialize(writer);
        }

        protected override TreeNode CreateTreeNodeInternal()
        {
            TreeNode value = Value?.CreateTreeNode() ?? new TreeNode();

            //if (Value is ValueTag)
            //    Debugger.Break();

            value.ContextMenuStrip ??= new();

            value.ContextMenuStrip.Items.Add("Edit name", null, (_, _) => 
            {
                StringEditDialogue.ShowDialog(Key, k => Key = k);
            }).Tag = ("name", this);

            value.ContextMenuStrip.Opening += (sender, _) =>
            {
                if (sender is ContextMenuStrip strip)
                    foreach (ToolStripItem item in strip.Items)
                    {
                        if (item.Tag is (string type, KeyValueTag tag) && type == "name" && tag == this)
                        {
                            item.Text = $"Edit name ({Key})";
                        }
                    }
            };

            value.Text = DisplayName.ConstrainLength(64, 256);
            return value;
        }

        public override string ToString()
        {
            if (Value is KeyValueTag)
                return $"{Key}.{Value}";
            return $"{Key}: {Value}";
        }

        public override T GetTag<T>(string tagId, string name)
        {
            if (Value is not T t)
                t = Convert<T>(this, Value, Value?.TagId ?? TagId, Value?.Name ?? Name);

            return t;
        }

        protected override void ChildNameChanged(Tag child, string name)
        {
            UpdateNodeName();
            NameChanged();
        }

        private void UpdateNodeName()
        {
            if (TreeNode is not null)
            {
                TreeNode.Text = DisplayName.ConstrainLength(64, 256);
            }
        }
    }
}
