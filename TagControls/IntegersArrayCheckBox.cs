using RainState.Tags;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RainState.TagControls
{
    public class IntegersArrayCheckBox : CheckBox, ITagControl
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
        public TagWatchController? Controller { get; set; }

        bool ChangingState = false;
        public void RefreshTag(Tag? parent)
        {
            Tag? tag = parent?.QueryTag(TagQuery, false);
            UpdateChecked(tag);
        }

        void OnTagChanged(Tag tag)
        {
            if (tag is not ValueTag value)
                return;

            UpdateChecked(tag);
        }

        void UpdateChecked(Tag? tag)
        {
            ChangingState = true;
            if (tag is ValueTag value)
            {
                string[] split = value.Value.Split(',');
                if (split.Length <= IntegerIndex)
                    Checked = false;

                else
                    Checked = split[IntegerIndex] == "1";
            }
            else
            {
                Checked = false;
            }
            ChangingState = false;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);

            if (ChangingState || Controller is null)
                return;

            TagWatcher.Enabled = false;
            Tag? tag = Controller?.GetTag()?.QueryTag(TagQuery);
            if (tag is ValueTag value)
            {
                string[] split = value.Value.Split(',');
                if (IntegerIndex >= split.Length)
                    Array.Resize(ref split, IntegerIndex + 1);

                split[IntegerIndex] = Checked ? "1" : "0";
                value.Value = string.Join(',', split);
            }

            TagWatcher.Enabled = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (ChangingState || Controller is null)
                return;

            TagWatcher.Enabled = false;
            Tag? tag = Controller?.GetTag()?.QueryTag(TagQuery);
            if (tag is ValueTag value)
                value.Value = Text;
            TagWatcher.Enabled = true;
        }
    }
}
