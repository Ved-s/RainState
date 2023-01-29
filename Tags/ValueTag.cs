﻿using RainState.Forms;
using System;
using System.Text;
using System.Windows.Forms;

namespace RainState.Tags
{
    public class ValueTag : Tag
    {
        private string value;

        public override string Name { get => Value; set => Value = value; }

        public string Value
        {
            get => value;
            set
            {
                this.value = value;

                if (TreeNode is not null)
                    TreeNode.Text = value;
                NameChanged();
                Changed();

            }
        }

        public ValueTag() : base("")
        {
            value = "";
        }

        public ValueTag(string value) : base("")
        {
            this.value = value;
        }

        public override void Serialize(StringBuilder builder)
        {
            builder.Append(Value);
        }

        protected override TreeNode CreateTreeNodeInternal(bool readOnly)
        {
            TreeNode node = new(Value.ConstrainLength(64, 256));

            node.ContextMenuStrip ??= new();

            if (!readOnly)
            {
                node.ContextMenuStrip.Items.Add("Edit value", null, (_, _) =>
                {
                    StringEditDialogue.ShowDialog(Value, k => Value = k);
                });
            }

            node.ContextMenuStrip.Items.Add("Copy value", null, (_, _) =>
            {
                Clipboard.SetText(Value);
            });

            return node;
        }

        public override string ToString()
        {
            return Value;
        }

        public override T GetTag<T>(string tagId, string name, bool create, string[]? filters)
        {
            throw new InvalidOperationException("Cannot query on string value");
        }
    }
}
