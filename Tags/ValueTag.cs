using RainState.Forms;
using System;
using System.IO;
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

        public override void Serialize(StreamWriter writer)
        {
            writer.Write(Value);
        }

        protected override TreeNode CreateTreeNodeInternal()
        {
            TreeNode node = new(Value.ConstrainLength(64, 256));

            node.ContextMenuStrip ??= new();
            node.ContextMenuStrip.Items.Add("Edit value", null, (_, _) =>
            {
                StringEditDialogue.ShowDialog(Value, k => Value = k);
            });

            return node;
        }

        public override string ToString()
        {
            return Value;
        }

        public override T GetTag<T>(string tagId, string name)
        {
            throw new InvalidOperationException();
        }
    }
}
