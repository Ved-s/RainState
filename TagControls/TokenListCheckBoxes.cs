using RainState.Tags;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainState.TagControls
{
    public class TokenListCheckBoxes : Panel, ITagControl
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

        public string[] Tokens = Array.Empty<string>();
        public Func<string, string>? DisplayNameGetter;

        Dictionary<string, CheckBox> CheckBoxes = new();
        FlowLayoutPanel CheckBoxesPanel = new();
        bool ChangingValue = false;
        HashSet<string> UpdateSet = new();

        public TokenListCheckBoxes()
        {
            BackColor = Color.FromArgb(36, 36, 36);

            CheckBoxesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            CheckBoxesPanel.Location = new(0, 25);
            CheckBoxesPanel.Size = new(Width, Height - 25);
            CheckBoxesPanel.AutoScroll = true;
            CheckBoxesPanel.Margin = new(0, 25, 0, 0);

            Controls.Add(CheckBoxesPanel);

            Button setAll = new();
            setAll.BackColor = Color.FromArgb(42, 42, 42);
            setAll.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            setAll.FlatStyle = FlatStyle.Flat;
            setAll.Text = "Check All";
            setAll.Size = new(80, 20);
            setAll.Location = new(3, 3);
            setAll.Click += (_, _) =>
            {
                ChangingValue = true;
                foreach (CheckBox cb in CheckBoxes.Values)
                    cb.Checked = true;
                ChangingValue = false;
                CheckBoxChanged(null);
            };
            Controls.Add(setAll);

            Button resetAll = new();
            resetAll.BackColor = Color.FromArgb(42, 42, 42);
            resetAll.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            resetAll.FlatStyle = FlatStyle.Flat;
            resetAll.Text = "Uncheck All";
            resetAll.Size = new(100, 20);
            resetAll.Location = new(86, 3);
            resetAll.Click += (_, _) =>
            {
                ChangingValue = true;
                foreach (CheckBox cb in CheckBoxes.Values)
                    cb.Checked = false;
                ChangingValue = false;
                CheckBoxChanged(null);
            };
            Controls.Add(resetAll);
        }

        public void RefreshTag(Tag? parent)
        {
            Tag? tag = parent?.QueryTag(TagQuery, false);
            CheckBoxes.Clear();
            CheckBoxesPanel.Controls.Clear();
            UpdateValue(tag);
        }

        void OnTagChanged(Tag tag)
        {
            UpdateValue(tag);
        }

        void UpdateValue(Tag? tag)
        {
            ChangingValue = true;
            string value = (tag as ValueTag)?.Value ?? "";

            UpdateSet.Clear();
            UpdateSet.UnionWith(value.Split(','));
            EnsureCheckBoxCount(UpdateSet);

            foreach (var (id, cb) in CheckBoxes)
                cb.Checked = UpdateSet.Contains(id);

            UpdateSet.Clear();
            ChangingValue = false;
        }

        void CheckBoxChanged(string? id)
        {
            if (ChangingValue)
                return;

            TagWatcher.Enabled = false;

            try
            {
                Tag? tag = Controller?.GetTag()?.QueryTag(TagQuery);
                if (tag is not ValueTag value)
                    return;

                UpdateSet.Clear();
                UpdateSet.UnionWith(value.Value.Split(','));

                if (id is not null)
                {
                    if (!CheckBoxes.TryGetValue(id, out CheckBox? checkBox))
                        return;

                    if (checkBox.Checked)
                        UpdateSet.Add(id);
                    else
                        UpdateSet.Remove(id);
                }
                else 
                {
                    foreach (var (cid, cb) in CheckBoxes)
                    {
                        if (cb.Checked)
                            UpdateSet.Add(cid);
                        else
                            UpdateSet.Remove(cid);
                    }
                }
                value.Value = string.Join(',', UpdateSet);
                UpdateSet.Clear();
            }
            finally
            {
                TagWatcher.Enabled = true;
            }
        }

        void EnsureCheckBoxCount(IEnumerable<string> names)
        {
            foreach (string id in names)
            {
                if (CheckBoxes.ContainsKey(id))
                    continue;

                CheckBox cb = new();
                cb.AutoSize = true;
                cb.Text = DisplayNameGetter is null ? id : DisplayNameGetter(id);
                cb.CheckedChanged += (_, _) => CheckBoxChanged(id);
                CheckBoxes.Add(id, cb);
                CheckBoxesPanel.Controls.Add(cb);
            }
        }
    }
}
