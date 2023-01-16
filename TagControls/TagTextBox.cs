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
    public class TagTextBox : TextBox, ITagControl
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
        [Browsable(false)]
        public TagWatch TagWatcher { get; private set; } = null!;
        public TagWatchController? Controller { get; set; }

        bool ChangingText = false;
        public void RefreshTag(Tag? parent)
        {
            Tag? tag = parent?.QueryTag(TagQuery, false);
            ChangingText = true;
            Text = (tag as ValueTag)?.Value ?? "";
            ChangingText = false;
        }

        void OnTagChanged(Tag tag)
        {
            if (tag is not ValueTag value)
                return;

            ChangingText = true;
            Text = value.Value;
            ChangingText = false;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (ChangingText || Controller is null)
                return;

            TagWatcher.Enabled = false;
            Tag? tag = Controller?.GetTag()?.QueryTag(TagQuery);
            if (tag is ValueTag value)
                value.Value = Text;
            TagWatcher.Enabled = true;
        }
    }
}
