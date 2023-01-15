using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

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

                if (TreeNode is TextBlock text)
                    text.Text = value;
            }
        }

        public ValueTag() : base("")
        {
            this.value = "";
        }

        public ValueTag(string value) : base("")
        {
            this.value = value;
        }

        public override void Serialize(StreamWriter writer)
        {
            writer.Write(Value);
        }

        protected override FrameworkElement CreateTreeNodeInternal()
        {
            return new TextBlock { Text = Value };
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
