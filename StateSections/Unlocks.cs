using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainState.StateSections
{
    public class Unlocks : UserControl
    {
#nullable disable
        private TagControls.TagWatchController MiscprogController;
        private TagControls.TokenListCheckBoxes SandboxTokens;
        private Label SandboxTokensLabel;
        private TagControls.TokenListCheckBoxes LevelTokens;
        private Label LevelTokensLabel;
#nullable restore

        public Unlocks() 
        {
            InitializeComponent();

            LevelTokens.Tokens = RainWorldData.LevelUnlocks ?? Array.Empty<string>();
            SandboxTokens.Tokens = RainWorldData.SandboxUnlocks ?? Array.Empty<string>();

            LevelTokens.DisplayNameGetter = id =>
            {
                if (RainWorldData.Regions is not null && RainWorldData.Regions.TryGetValue(id, out RainWorldData.Region? region))
                    return region.Name ?? id;
                return id;
            };
        }

        private void InitializeComponent()
        {
            this.MiscprogController = new RainState.TagControls.TagWatchController();
            this.SandboxTokens = new RainState.TagControls.TokenListCheckBoxes();
            this.SandboxTokensLabel = new System.Windows.Forms.Label();
            this.LevelTokens = new RainState.TagControls.TokenListCheckBoxes();
            this.LevelTokensLabel = new System.Windows.Forms.Label();
            this.MiscprogController.SuspendLayout();
            this.SuspendLayout();
            // 
            // MiscprogController
            // 
            this.MiscprogController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MiscprogController.Controller = null;
            this.MiscprogController.Controls.Add(this.SandboxTokens);
            this.MiscprogController.Controls.Add(this.SandboxTokensLabel);
            this.MiscprogController.Controls.Add(this.LevelTokens);
            this.MiscprogController.Controls.Add(this.LevelTokensLabel);
            this.MiscprogController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiscprogController.Location = new System.Drawing.Point(0, 0);
            this.MiscprogController.MainController = false;
            this.MiscprogController.Name = "MiscprogController";
            this.MiscprogController.Size = new System.Drawing.Size(493, 363);
            this.MiscprogController.TabIndex = 0;
            this.MiscprogController.WatchQuery = "progDiv@MISCPROG/mpd$";
            // 
            // SandboxTokens
            // 
            this.SandboxTokens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SandboxTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SandboxTokens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SandboxTokens.Controller = null;
            this.SandboxTokens.Location = new System.Drawing.Point(3, 200);
            this.SandboxTokens.Name = "SandboxTokens";
            this.SandboxTokens.Size = new System.Drawing.Size(487, 160);
            this.SandboxTokens.TabIndex = 27;
            this.SandboxTokens.TagQuery = "mpd@SANDBOXTOKENS/#";
            // 
            // SandboxTokensLabel
            // 
            this.SandboxTokensLabel.AutoSize = true;
            this.SandboxTokensLabel.Location = new System.Drawing.Point(0, 183);
            this.SandboxTokensLabel.Name = "SandboxTokensLabel";
            this.SandboxTokensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SandboxTokensLabel.Size = new System.Drawing.Size(137, 15);
            this.SandboxTokensLabel.TabIndex = 28;
            this.SandboxTokensLabel.Text = "Unlocked sandbox items";
            // 
            // LevelTokens
            // 
            this.LevelTokens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.LevelTokens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LevelTokens.Controller = null;
            this.LevelTokens.Location = new System.Drawing.Point(3, 20);
            this.LevelTokens.Name = "LevelTokens";
            this.LevelTokens.Size = new System.Drawing.Size(487, 160);
            this.LevelTokens.TabIndex = 25;
            this.LevelTokens.TagQuery = "mpd@LEVELTOKENS/#";
            // 
            // LevelTokensLabel
            // 
            this.LevelTokensLabel.AutoSize = true;
            this.LevelTokensLabel.Location = new System.Drawing.Point(0, 3);
            this.LevelTokensLabel.Name = "LevelTokensLabel";
            this.LevelTokensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LevelTokensLabel.Size = new System.Drawing.Size(94, 15);
            this.LevelTokensLabel.TabIndex = 26;
            this.LevelTokensLabel.Text = "Unlocked arenas";
            // 
            // Unlocks
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.MiscprogController);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Unlocks";
            this.Size = new System.Drawing.Size(493, 363);
            this.MiscprogController.ResumeLayout(false);
            this.MiscprogController.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
