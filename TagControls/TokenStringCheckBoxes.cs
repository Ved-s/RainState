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
    public class TokenStringCheckBoxes : Panel, ITagControl
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

        public Func<int>? MinCountGetter;
        public Func<int, string>? CheckBoxNameGetter;

        List<CheckBox> CheckBoxes = new();
        FlowLayoutPanel CheckBoxesPanel = new();
        bool ChangingValue = false;

        public TokenStringCheckBoxes()
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
                foreach (CheckBox cb in CheckBoxes)
                    cb.Checked = true;
                ChangingValue = false;
                CheckBoxChanged(-1);
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
                foreach (CheckBox cb in CheckBoxes)
                    cb.Checked = false;
                ChangingValue = false;
                CheckBoxChanged(-1);
            };
            Controls.Add(resetAll);
        }

        public void RefreshTag(Tag? parent)
        {
            Tag? tag = parent?.QueryTag(TagQuery, false);

            for (int i = 0; i < CheckBoxes.Count; i++)
                CheckBoxes[i].Text = GetName(i);

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
            int len = Math.Max(MinCountGetter?.Invoke() ?? 0, value.Length);
            EnsureCheckBoxCount(len);

            for (int i = 0; i < CheckBoxes.Count; i++)
            {
                bool v = value.Length > i && value[i] == '1';
                CheckBoxes[i].Checked = v;
            }

            ChangingValue = false;
        }

        string GetName(int index)
        {
            return CheckBoxNameGetter?.Invoke(index) ?? $"CheckBox {index}";
        }

        void CheckBoxChanged(int index)
        {
            if (ChangingValue)
                return;

            TagWatcher.Enabled = false;

            try
            {
                Tag? tag = Controller?.GetTag()?.QueryTag(TagQuery);
                if (tag is not ValueTag value)
                    return;
                string str = value.Value;

                Span<char> span = stackalloc char[Math.Max(str.Length, CheckBoxes.Count)];

                for (int i = 0; i < span.Length; i++)
                {
                    if (i < str.Length)
                        span[i] = str[i];
                    else
                        span[i] = '0';

                    if ((index < 0 || index == i) && i < CheckBoxes.Count)
                        span[i] = CheckBoxes[i].Checked ? '1' : '0';
                }

                value.Value = new(span);
            }
            finally
            {
                TagWatcher.Enabled = true;
            }
        }

        void EnsureCheckBoxCount(int count)
        {
            while (CheckBoxes.Count < count)
            {
                int index = CheckBoxes.Count;
                CheckBox cb = new();
                cb.AutoSize = true;
                cb.Text = GetName(index);
                cb.CheckedChanged += (_, _) => CheckBoxChanged(index);
                CheckBoxes.Add(cb);
                CheckBoxesPanel.Controls.Add(cb);
            }
        }
    }
}
