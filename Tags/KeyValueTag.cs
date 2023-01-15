using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace RainState.Tags
{
    public class KeyValueTag : Tag
    {
        private string key;
        private TextBlock? KeyText;
        private MenuItem? ValueEditMenu;

        public Tag? Value;
        public bool Alternative;

        public override string Name { get => Key; set => Key = value; }

        public string Key
        {
            get => key;
            set
            {
                key = value;

                if (KeyText is not null)
                    KeyText.Text = value;
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

        protected override FrameworkElement CreateTreeNodeInternal()
        {
            FrameworkElement value = Value?.CreateTreeNode() ?? new TextBlock();
            KeyText = new TextBlock { Text = Key };

            MenuItem setKey = new MenuItem()
            {
                Header = "Edit name"
            };
            setKey.Click += (_, _) => StringEditDialogue.Show(Key, k => Key = k);

            ContextMenu ctxm = new()
            {
                Items = { setKey }
            };

            ValueEditMenu = new MenuItem()
            {
                Header = "Edit value"
            };
            ValueEditMenu.Click += (_, _) =>
            {
                if (Value is not ValueTag vt)
                    return;

                StringEditDialogue.Show(vt.Value, v => vt.Value = v);
            };

            ctxm.Opened += (_, _) =>
            {
                ctxm.Items.Remove(ValueEditMenu);

                if (Value is ValueTag vt)
                    ctxm.Items.Add(ValueEditMenu);
            };

            if (value is TreeViewItem item)
            {
                item.Header = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Children =
                    {
                        KeyText,
                        new TextBlock { Text = $" <{Value!.TagId}>" },
                    },
                    ContextMenu = ctxm
                };
                item.ContextMenu = ctxm;

                return item;
            }

            return new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Children =
                {
                    //new TextBlock { Text = TagId + "$" },
                    KeyText,
                    new TextBlock { Text = ": " },
                    value
                },
                ContextMenu = ctxm
            };
        }

        public override string ToString()
        {
            if (Value is KeyValueTag)
                return $"{Key}.{Value}";
            return $"{Key}: {Value}";
        }

        public override T GetTag<T>(string tagId, string name)
        {
            throw new InvalidOperationException();
        }

        public T GetValue<T>() where T : Tag
        {
            if (Value is not T t)
                t = Tag.Convert<T>(Value, Value?.TagId ?? TagId, Value?.Name ?? Name);

            return t;
        }
    }
}
