using RainState.Icons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainState.Controls
{
    public class CollapsedPanel : Panel
    {
        const int CollapsedHeight = 24;

        [Browsable(true)]
        public override string Text { get => Title.Text; set => Title.Text = value; }

        Label Title = new();
        Button Collapse = new();

        public int ContentHeight { get; set; }

        bool collapsed = false;
        public bool Collapsed 
        {
            get => collapsed;
            set 
            {
                if (collapsed == value)
                    return;

                collapsed = value;
                if (collapsed)
                {
                    foreach (Control c in Controls)
                        if (c != Title && c != Collapse)
                            c.Visible = false;

                    ContentHeight = Height - CollapsedHeight;
                    Height = CollapsedHeight;
                    Collapse.BackgroundImage = Icons.Icons.ArrowDown16;
                }
                else 
                {
                    Height = ContentHeight + CollapsedHeight;

                    foreach (Control c in Controls)
                        if (c != Title && c != Collapse)
                            c.Visible = true;

                    Collapse.BackgroundImage = Icons.Icons.ArrowLeft16;
                }
            }
        }

        public CollapsedPanel() 
        {
            BackColor = Color.FromArgb(32, 32, 32);
            BorderStyle = BorderStyle.FixedSingle;

            Padding = new(0, 22, 0, 0);

            Collapse.Size = new(16, 16);
            Collapse.Location = new(3, 3);
            //Collapse.BackColor = Color.FromArgb(32, 32, 32);
            Collapse.FlatAppearance.BorderSize = 0;
            Collapse.FlatStyle = FlatStyle.Flat;
            Collapse.Click += (_, _) => Collapsed = !Collapsed;
            Collapse.BackgroundImageLayout = ImageLayout.Center;
            Collapse.BackgroundImage = Icons.Icons.ArrowLeft16;

            Title.Location = new(23, 3);
            Title.AutoSize = false;
            Title.Size = new(Width - Collapse.Width - 6 + 1000, 20);
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            Title.Click += (_, _) => Collapsed = !Collapsed;

            Controls.Add(Collapse);
            Controls.Add(Title);
        }
    }
}
