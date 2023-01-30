using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainState.Controls
{
    public class TabSwitch : UserControl
    {
#nullable disable
        private Panel ContentPanel;
        private FlowLayoutPanel SwitchPanel;
#nullable restore

        Dictionary<string, Control> Tabs = new();
        Control? CurrentTab;

        public TabSwitch()
        {
            InitializeComponent();
        }

        public void AddTab(string name, Control content)
        { 
            Tabs[name] = content;

            Button button = new()
            {
                Text = name,
                FlatStyle = FlatStyle.Flat,
                AutoSize = true,
                FlatAppearance = 
                {
                    BorderColor = Color.Gray
                },
                MaximumSize = new(0, 22)
            };
            button.Click += (_, _) => 
            {
                if (CurrentTab is not null)
                {
                    CurrentTab.BackColor = SwitchPanel.BackColor;
                    foreach (Control c in ContentPanel.Controls)
                        c.Visible = false;
                }

                if (CurrentTab is null || CurrentTab != button)
                {
                    button.BackColor = Color.FromArgb(48, 48, 48);
                    content.Visible = true;
                    CurrentTab = button;
                }
                else
                    CurrentTab = null;
            };
            SwitchPanel.Controls.Add(button);

            content.Dock = DockStyle.Fill;
            content.Visible = false;

            ContentPanel.Controls.Add(content);
        }

        public void ClearTabs()
        {
            Tabs.Clear();
            ContentPanel.Controls.Clear();
            SwitchPanel.Controls.Clear();
        }

        private void InitializeComponent()
        {
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SwitchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(364, 237);
            this.ContentPanel.TabIndex = 0;
            // 
            // SwitchPanel
            // 
            this.SwitchPanel.AutoSize = true;
            this.SwitchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SwitchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SwitchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchPanel.Location = new System.Drawing.Point(0, 0);
            this.SwitchPanel.Name = "SwitchPanel";
            this.SwitchPanel.Size = new System.Drawing.Size(364, 2);
            this.SwitchPanel.TabIndex = 1;
            // 
            // TabSwitch
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SwitchPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "TabSwitch";
            this.Size = new System.Drawing.Size(364, 239);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
