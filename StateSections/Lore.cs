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
    public class Lore : UserControl
    {
#nullable disable
        private TagWatchController MiscprogController;
        private Label LoreLabel;
        private TokenListCheckBoxes LorePearls;
        private Label LorePLabel;
        private TokenListCheckBoxes LoreP;
        private Label LoreDMLabel;
        private TokenListCheckBoxes LoreDM;
        private Label LoreFutLabel;
        private TokenListCheckBoxes LoreFut;
        private Label BroadcastsLabel;
        private TokenListCheckBoxes Broadcasts;
#nullable restore

        public Lore() 
        {
            InitializeComponent();

            MiscprogController.OnRefresh = parent =>
            {
                LorePearls.Tokens = RainWorldData.LorePearls ?? Array.Empty<string>();
                LoreP.Tokens = RainWorldData.LorePearls ?? Array.Empty<string>();
                LoreDM.Tokens = RainWorldData.LorePearls ?? Array.Empty<string>();
                LoreFut.Tokens = RainWorldData.LorePearls ?? Array.Empty<string>();
                Broadcasts.Tokens = RainWorldData.Broadcasts ?? Array.Empty<string>();
            };
        }

        private void InitializeComponent()
        {
            this.MiscprogController = new RainState.TagControls.TagWatchController();
            this.Broadcasts = new RainState.TagControls.TokenListCheckBoxes();
            this.BroadcastsLabel = new System.Windows.Forms.Label();
            this.LoreFut = new RainState.TagControls.TokenListCheckBoxes();
            this.LoreP = new RainState.TagControls.TokenListCheckBoxes();
            this.LoreFutLabel = new System.Windows.Forms.Label();
            this.LorePLabel = new System.Windows.Forms.Label();
            this.LoreDM = new RainState.TagControls.TokenListCheckBoxes();
            this.LoreDMLabel = new System.Windows.Forms.Label();
            this.LorePearls = new RainState.TagControls.TokenListCheckBoxes();
            this.LoreLabel = new System.Windows.Forms.Label();
            this.MiscprogController.SuspendLayout();
            this.SuspendLayout();
            // 
            // MiscprogController
            // 
            this.MiscprogController.AutoScroll = true;
            this.MiscprogController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MiscprogController.Controller = null;
            this.MiscprogController.Controls.Add(this.Broadcasts);
            this.MiscprogController.Controls.Add(this.BroadcastsLabel);
            this.MiscprogController.Controls.Add(this.LoreFut);
            this.MiscprogController.Controls.Add(this.LoreP);
            this.MiscprogController.Controls.Add(this.LoreFutLabel);
            this.MiscprogController.Controls.Add(this.LorePLabel);
            this.MiscprogController.Controls.Add(this.LoreDM);
            this.MiscprogController.Controls.Add(this.LoreDMLabel);
            this.MiscprogController.Controls.Add(this.LorePearls);
            this.MiscprogController.Controls.Add(this.LoreLabel);
            this.MiscprogController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiscprogController.Location = new System.Drawing.Point(0, 0);
            this.MiscprogController.MainController = false;
            this.MiscprogController.Name = "MiscprogController";
            this.MiscprogController.Size = new System.Drawing.Size(493, 703);
            this.MiscprogController.TabIndex = 0;
            this.MiscprogController.WatchQuery = "progDiv@MISCPROG/mpd$";
            // 
            // Broadcasts
            // 
            this.Broadcasts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Broadcasts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Broadcasts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Broadcasts.Controller = null;
            this.Broadcasts.Location = new System.Drawing.Point(3, 580);
            this.Broadcasts.Name = "Broadcasts";
            this.Broadcasts.Size = new System.Drawing.Size(487, 120);
            this.Broadcasts.TabIndex = 33;
            this.Broadcasts.TagQuery = "mpd@BROADCASTS/#";
            // 
            // BroadcastsLabel
            // 
            this.BroadcastsLabel.AutoSize = true;
            this.BroadcastsLabel.Location = new System.Drawing.Point(0, 563);
            this.BroadcastsLabel.Name = "BroadcastsLabel";
            this.BroadcastsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BroadcastsLabel.Size = new System.Drawing.Size(124, 15);
            this.BroadcastsLabel.TabIndex = 34;
            this.BroadcastsLabel.Text = "Broadcasts discovered";
            // 
            // LoreFut
            // 
            this.LoreFut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoreFut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.LoreFut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoreFut.Controller = null;
            this.LoreFut.Location = new System.Drawing.Point(3, 440);
            this.LoreFut.Name = "LoreFut";
            this.LoreFut.Size = new System.Drawing.Size(487, 120);
            this.LoreFut.TabIndex = 31;
            this.LoreFut.TagQuery = "mpd@LOREFUT/#";
            // 
            // LoreP
            // 
            this.LoreP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoreP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.LoreP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoreP.Controller = null;
            this.LoreP.Location = new System.Drawing.Point(3, 160);
            this.LoreP.Name = "LoreP";
            this.LoreP.Size = new System.Drawing.Size(487, 120);
            this.LoreP.TabIndex = 27;
            this.LoreP.TagQuery = "mpd@LOREP/#";
            // 
            // LoreFutLabel
            // 
            this.LoreFutLabel.AutoSize = true;
            this.LoreFutLabel.Location = new System.Drawing.Point(0, 423);
            this.LoreFutLabel.Name = "LoreFutLabel";
            this.LoreFutLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoreFutLabel.Size = new System.Drawing.Size(157, 15);
            this.LoreFutLabel.TabIndex = 32;
            this.LoreFutLabel.Text = "Future lore pears deciphered";
            // 
            // LorePLabel
            // 
            this.LorePLabel.AutoSize = true;
            this.LorePLabel.Location = new System.Drawing.Point(0, 143);
            this.LorePLabel.Name = "LorePLabel";
            this.LorePLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LorePLabel.Size = new System.Drawing.Size(167, 15);
            this.LorePLabel.TabIndex = 28;
            this.LorePLabel.Text = "Pebbles lore pearls deciphered";
            // 
            // LoreDM
            // 
            this.LoreDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoreDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.LoreDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoreDM.Controller = null;
            this.LoreDM.Location = new System.Drawing.Point(3, 300);
            this.LoreDM.Name = "LoreDM";
            this.LoreDM.Size = new System.Drawing.Size(487, 120);
            this.LoreDM.TabIndex = 29;
            this.LoreDM.TagQuery = "mpd@LOREDM/#";
            // 
            // LoreDMLabel
            // 
            this.LoreDMLabel.AutoSize = true;
            this.LoreDMLabel.Location = new System.Drawing.Point(0, 283);
            this.LoreDMLabel.Name = "LoreDMLabel";
            this.LoreDMLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoreDMLabel.Size = new System.Drawing.Size(145, 15);
            this.LoreDMLabel.TabIndex = 30;
            this.LoreDMLabel.Text = "DM lore pearls deciphered";
            // 
            // LorePearls
            // 
            this.LorePearls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LorePearls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.LorePearls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LorePearls.Controller = null;
            this.LorePearls.Location = new System.Drawing.Point(3, 20);
            this.LorePearls.Name = "LorePearls";
            this.LorePearls.Size = new System.Drawing.Size(487, 120);
            this.LorePearls.TabIndex = 25;
            this.LorePearls.TagQuery = "mpd@LORE/#";
            // 
            // LoreLabel
            // 
            this.LoreLabel.AutoSize = true;
            this.LoreLabel.Location = new System.Drawing.Point(0, 3);
            this.LoreLabel.Name = "LoreLabel";
            this.LoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoreLabel.Size = new System.Drawing.Size(126, 15);
            this.LoreLabel.TabIndex = 26;
            this.LoreLabel.Text = "Lore pearls deciphered";
            // 
            // Lore
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.MiscprogController);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Lore";
            this.Size = new System.Drawing.Size(493, 703);
            this.MiscprogController.ResumeLayout(false);
            this.MiscprogController.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}
