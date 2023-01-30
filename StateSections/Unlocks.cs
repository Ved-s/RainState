using RainState.TagControls;
using RainState.Tags;
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
        private Label LevelTokensLabel;
        private TagControls.TokenListCheckBoxes LevelTokens;
        private Label SandboxTokensLabel;
        private TagControls.TokenListCheckBoxes SandboxTokens;
        private Label SafariTokensLabel;
        private TagControls.TokenListCheckBoxes SafariTokens;
        private Label SlugcatTokensLabel;
        private TagControls.TokenListCheckBoxes SlugcatTokens;
#nullable restore

        public Unlocks() 
        {
            InitializeComponent();

            MiscprogController.OnRefresh = parent =>
            {
                LevelTokens.Tokens = RainWorldData.LevelUnlocks ?? Array.Empty<string>();
                SandboxTokens.Tokens = RainWorldData.SandboxUnlocks ?? Array.Empty<string>();
                SafariTokens.Tokens = RainWorldData.SafariUnlocks ?? Array.Empty<string>();
                SlugcatTokens.Tokens = RainWorldData.SlugcatUnlocks ?? Array.Empty<string>();
            };

            Func<string, string> regionNameSelector = id =>
            {
                if (RainWorldData.Regions is not null && RainWorldData.Regions.TryGetValue(id, out RainWorldData.Region? region))
                    return region.Name ?? id;
                return id;

            };
            LevelTokens.DisplayNameGetter = regionNameSelector;
            SafariTokens.DisplayNameGetter = regionNameSelector;
        }

        private void InitializeComponent()
        {
            this.MiscprogController = new RainState.TagControls.TagWatchController();
            this.SlugcatTokens = new RainState.TagControls.TokenListCheckBoxes();
            this.SandboxTokens = new RainState.TagControls.TokenListCheckBoxes();
            this.SlugcatTokensLabel = new System.Windows.Forms.Label();
            this.SandboxTokensLabel = new System.Windows.Forms.Label();
            this.SafariTokens = new RainState.TagControls.TokenListCheckBoxes();
            this.SafariTokensLabel = new System.Windows.Forms.Label();
            this.LevelTokens = new RainState.TagControls.TokenListCheckBoxes();
            this.LevelTokensLabel = new System.Windows.Forms.Label();
            this.MiscprogController.SuspendLayout();
            this.SuspendLayout();
            // 
            // MiscprogController
            // 
            this.MiscprogController.AutoScroll = true;
            this.MiscprogController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MiscprogController.Controller = null;
            this.MiscprogController.Controls.Add(this.SlugcatTokens);
            this.MiscprogController.Controls.Add(this.SandboxTokens);
            this.MiscprogController.Controls.Add(this.SlugcatTokensLabel);
            this.MiscprogController.Controls.Add(this.SandboxTokensLabel);
            this.MiscprogController.Controls.Add(this.SafariTokens);
            this.MiscprogController.Controls.Add(this.SafariTokensLabel);
            this.MiscprogController.Controls.Add(this.LevelTokens);
            this.MiscprogController.Controls.Add(this.LevelTokensLabel);
            this.MiscprogController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiscprogController.Location = new System.Drawing.Point(0, 0);
            this.MiscprogController.MainController = false;
            this.MiscprogController.Name = "MiscprogController";
            this.MiscprogController.Size = new System.Drawing.Size(493, 564);
            this.MiscprogController.TabIndex = 0;
            this.MiscprogController.WatchQuery = "progDiv@MISCPROG/mpd$";
            // 
            // SlugcatTokens
            // 
            this.SlugcatTokens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SlugcatTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SlugcatTokens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SlugcatTokens.Controller = null;
            this.SlugcatTokens.Location = new System.Drawing.Point(3, 440);
            this.SlugcatTokens.Name = "SlugcatTokens";
            this.SlugcatTokens.Size = new System.Drawing.Size(487, 120);
            this.SlugcatTokens.TabIndex = 31;
            this.SlugcatTokens.TagQuery = "mpd@CLASSTOKENS/#";
            // 
            // SandboxTokens
            // 
            this.SandboxTokens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SandboxTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SandboxTokens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SandboxTokens.Controller = null;
            this.SandboxTokens.Location = new System.Drawing.Point(3, 160);
            this.SandboxTokens.Name = "SandboxTokens";
            this.SandboxTokens.Size = new System.Drawing.Size(487, 120);
            this.SandboxTokens.TabIndex = 27;
            this.SandboxTokens.TagQuery = "mpd@SANDBOXTOKENS/#";
            // 
            // SlugcatTokensLabel
            // 
            this.SlugcatTokensLabel.AutoSize = true;
            this.SlugcatTokensLabel.Location = new System.Drawing.Point(0, 423);
            this.SlugcatTokensLabel.Name = "SlugcatTokensLabel";
            this.SlugcatTokensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SlugcatTokensLabel.Size = new System.Drawing.Size(137, 15);
            this.SlugcatTokensLabel.TabIndex = 32;
            this.SlugcatTokensLabel.Text = "Unlocked slugcat classes";
            // 
            // SandboxTokensLabel
            // 
            this.SandboxTokensLabel.AutoSize = true;
            this.SandboxTokensLabel.Location = new System.Drawing.Point(0, 143);
            this.SandboxTokensLabel.Name = "SandboxTokensLabel";
            this.SandboxTokensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SandboxTokensLabel.Size = new System.Drawing.Size(137, 15);
            this.SandboxTokensLabel.TabIndex = 28;
            this.SandboxTokensLabel.Text = "Unlocked sandbox items";
            // 
            // SafariTokens
            // 
            this.SafariTokens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SafariTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SafariTokens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SafariTokens.Controller = null;
            this.SafariTokens.Location = new System.Drawing.Point(3, 300);
            this.SafariTokens.Name = "SafariTokens";
            this.SafariTokens.Size = new System.Drawing.Size(487, 120);
            this.SafariTokens.TabIndex = 29;
            this.SafariTokens.TagQuery = "mpd@SAFARITOKENS/#";
            // 
            // SafariTokensLabel
            // 
            this.SafariTokensLabel.AutoSize = true;
            this.SafariTokensLabel.Location = new System.Drawing.Point(0, 283);
            this.SafariTokensLabel.Name = "SafariTokensLabel";
            this.SafariTokensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SafariTokensLabel.Size = new System.Drawing.Size(88, 15);
            this.SafariTokensLabel.TabIndex = 30;
            this.SafariTokensLabel.Text = "Unlocked safari";
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
            this.LevelTokens.Size = new System.Drawing.Size(487, 120);
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
            this.Size = new System.Drawing.Size(493, 564);
            this.MiscprogController.ResumeLayout(false);
            this.MiscprogController.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}
