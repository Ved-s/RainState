using RainState.Tags;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainState.TagControls
{
    public class IntegersArrayTextBox : TextBox, ITagControl
    {
        private string? tagQuery;

        public string TagQuery
        {
            get => tagQuery!;
            set
            {
                tagQuery = value;
                TagWatcher = new(value)
                {
                    WatchChildren = false,
                    OnTagChanged = OnTagChanged
                };
            }
        }

        public int IntegerIndex { get; set; } = 0;

        [Browsable(false)]
        public TagWatch TagWatcher { get; private set; } = null!;
        [Browsable(false)]
        public TagWatchController? Controller { get; set; }

        bool ChangingText = false;
        public void RefreshTag(Tag? parent)
        {
            Tag? tag = parent?.QueryTag(TagQuery, false);
            UpdateText(tag);
        }

        void OnTagChanged(Tag tag)
        {
            if (tag is not ValueTag)
                return;

            UpdateText(tag);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (ChangingText || Controller is null)
                return;

            TagWatcher.Enabled = false;
            Tag? tag = Controller?.GetTag()?.QueryTag(TagQuery);
            if (tag is ValueTag value)
            {
                string[] split = value.Value.Split(',');
                if (IntegerIndex >= split.Length)
                    Array.Resize(ref split, IntegerIndex + 1);

                split[IntegerIndex] = Text;
                value.Value = string.Join(',', split);
            }
            TagWatcher.Enabled = true;
        }

        void UpdateText(Tag? tag)
        {
            ChangingText = true;
            if (tag is ValueTag value)
            {
                string[] split = value.Value.Split(',');
                if (split.Length <= IntegerIndex)
                    Text = "";

                else
                    Text = split[IntegerIndex];
            }
            else
            {
                Text = "";
            }
            ChangingText = false;
        }
    }
}
