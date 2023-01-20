using RainState.Controls;
using RainState.TagControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RainState.StateSections
{
    public class MoreSlugcats : UserControl
    {
#nullable disable
        private TagWatchController MainTagController;
        private IntegersArrayTextBox PrePebblesBroadcasts;
        private IntegersArrayCheckBox BeatenSpearmaster;
        private IntegersArrayTextBox PostPebblesBroadcasts;
        private Label PostPebblesBroadcastsLabel;
        private IntegersArrayCheckBox ArtificerEnding;
        private IntegersArrayTextBox SurvivorPupsAtEnding;
        private Label SurvivorPupsAtEndingLabel;
        private IntegersArrayCheckBox MonkEnding;
        private IntegersArrayCheckBox SurvivorEnding;
        private IntegersArrayCheckBox BeatenHunter;
        private IntegersArrayCheckBox BeatenSurvivor;
        private IntegersArrayCheckBox BeatenSaint;
        private IntegersArrayCheckBox BeatenRivulet;
        private IntegersArrayCheckBox BeatenGourmandFull;
        private IntegersArrayCheckBox BeatenGourmand;
        private IntegersArrayCheckBox BeatenArtificer;
        private Label PrePebblesBroadcastsLabel;
#nullable restore

        public MoreSlugcats()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.PrePebblesBroadcastsLabel = new System.Windows.Forms.Label();
            this.MainTagController = new RainState.TagControls.TagWatchController();
            this.BeatenSpearmaster = new RainState.TagControls.IntegersArrayCheckBox();
            this.PostPebblesBroadcasts = new RainState.TagControls.IntegersArrayTextBox();
            this.PostPebblesBroadcastsLabel = new System.Windows.Forms.Label();
            this.PrePebblesBroadcasts = new RainState.TagControls.IntegersArrayTextBox();
            this.BeatenArtificer = new RainState.TagControls.IntegersArrayCheckBox();
            this.BeatenGourmandFull = new RainState.TagControls.IntegersArrayCheckBox();
            this.BeatenGourmand = new RainState.TagControls.IntegersArrayCheckBox();
            this.BeatenSaint = new RainState.TagControls.IntegersArrayCheckBox();
            this.BeatenRivulet = new RainState.TagControls.IntegersArrayCheckBox();
            this.BeatenHunter = new RainState.TagControls.IntegersArrayCheckBox();
            this.BeatenSurvivor = new RainState.TagControls.IntegersArrayCheckBox();
            this.MonkEnding = new RainState.TagControls.IntegersArrayCheckBox();
            this.SurvivorEnding = new RainState.TagControls.IntegersArrayCheckBox();
            this.SurvivorPupsAtEnding = new RainState.TagControls.IntegersArrayTextBox();
            this.SurvivorPupsAtEndingLabel = new System.Windows.Forms.Label();
            this.ArtificerEnding = new RainState.TagControls.IntegersArrayCheckBox();
            this.MainTagController.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrePebblesBroadcastsLabel
            // 
            this.PrePebblesBroadcastsLabel.AutoSize = true;
            this.PrePebblesBroadcastsLabel.Location = new System.Drawing.Point(3, 4);
            this.PrePebblesBroadcastsLabel.Name = "PrePebblesBroadcastsLabel";
            this.PrePebblesBroadcastsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PrePebblesBroadcastsLabel.Size = new System.Drawing.Size(182, 15);
            this.PrePebblesBroadcastsLabel.TabIndex = 6;
            this.PrePebblesBroadcastsLabel.Text = "Broadcasts before visited Pebbles";
            // 
            // MainTagController
            // 
            this.MainTagController.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainTagController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MainTagController.Controller = null;
            this.MainTagController.Controls.Add(this.ArtificerEnding);
            this.MainTagController.Controls.Add(this.SurvivorPupsAtEnding);
            this.MainTagController.Controls.Add(this.SurvivorPupsAtEndingLabel);
            this.MainTagController.Controls.Add(this.MonkEnding);
            this.MainTagController.Controls.Add(this.SurvivorEnding);
            this.MainTagController.Controls.Add(this.BeatenHunter);
            this.MainTagController.Controls.Add(this.BeatenSurvivor);
            this.MainTagController.Controls.Add(this.BeatenSaint);
            this.MainTagController.Controls.Add(this.BeatenRivulet);
            this.MainTagController.Controls.Add(this.BeatenGourmandFull);
            this.MainTagController.Controls.Add(this.BeatenGourmand);
            this.MainTagController.Controls.Add(this.BeatenArtificer);
            this.MainTagController.Controls.Add(this.BeatenSpearmaster);
            this.MainTagController.Controls.Add(this.PostPebblesBroadcasts);
            this.MainTagController.Controls.Add(this.PostPebblesBroadcastsLabel);
            this.MainTagController.Controls.Add(this.PrePebblesBroadcasts);
            this.MainTagController.Controls.Add(this.PrePebblesBroadcastsLabel);
            this.MainTagController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTagController.Location = new System.Drawing.Point(0, 0);
            this.MainTagController.MainController = false;
            this.MainTagController.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.MainTagController.Name = "MainTagController";
            this.MainTagController.Size = new System.Drawing.Size(427, 214);
            this.MainTagController.TabIndex = 0;
            this.MainTagController.WatchQuery = "progDiv@MISCPROG/mpd$";
            // 
            // BeatenSpearmaster
            // 
            this.BeatenSpearmaster.AutoSize = true;
            this.BeatenSpearmaster.Controller = null;
            this.BeatenSpearmaster.IntegerIndex = 3;
            this.BeatenSpearmaster.Location = new System.Drawing.Point(5, 47);
            this.BeatenSpearmaster.Name = "BeatenSpearmaster";
            this.BeatenSpearmaster.Size = new System.Drawing.Size(130, 19);
            this.BeatenSpearmaster.TabIndex = 23;
            this.BeatenSpearmaster.TagQuery = "mpd@INTEGERSMSC/#";
            this.BeatenSpearmaster.Text = "Beaten Spearmaster";
            this.BeatenSpearmaster.UseVisualStyleBackColor = true;
            // 
            // PostPebblesBroadcasts
            // 
            this.PostPebblesBroadcasts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PostPebblesBroadcasts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostPebblesBroadcasts.Controller = null;
            this.PostPebblesBroadcasts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostPebblesBroadcasts.IntegerIndex = 1;
            this.PostPebblesBroadcasts.Location = new System.Drawing.Point(200, 22);
            this.PostPebblesBroadcasts.Multiline = true;
            this.PostPebblesBroadcasts.Name = "PostPebblesBroadcasts";
            this.PostPebblesBroadcasts.Size = new System.Drawing.Size(123, 19);
            this.PostPebblesBroadcasts.TabIndex = 21;
            this.PostPebblesBroadcasts.TagQuery = "mpd@INTEGERSMSC/#";
            this.PostPebblesBroadcasts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PostPebblesBroadcastsLabel
            // 
            this.PostPebblesBroadcastsLabel.AutoSize = true;
            this.PostPebblesBroadcastsLabel.Location = new System.Drawing.Point(198, 4);
            this.PostPebblesBroadcastsLabel.Name = "PostPebblesBroadcastsLabel";
            this.PostPebblesBroadcastsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostPebblesBroadcastsLabel.Size = new System.Drawing.Size(172, 15);
            this.PostPebblesBroadcastsLabel.TabIndex = 22;
            this.PostPebblesBroadcastsLabel.Text = "Broadcasts after visited Pebbles";
            // 
            // PrePebblesBroadcasts
            // 
            this.PrePebblesBroadcasts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PrePebblesBroadcasts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrePebblesBroadcasts.Controller = null;
            this.PrePebblesBroadcasts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrePebblesBroadcasts.IntegerIndex = 0;
            this.PrePebblesBroadcasts.Location = new System.Drawing.Point(5, 22);
            this.PrePebblesBroadcasts.Multiline = true;
            this.PrePebblesBroadcasts.Name = "PrePebblesBroadcasts";
            this.PrePebblesBroadcasts.Size = new System.Drawing.Size(123, 19);
            this.PrePebblesBroadcasts.TabIndex = 5;
            this.PrePebblesBroadcasts.TagQuery = "mpd@INTEGERSMSC/#";
            this.PrePebblesBroadcasts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BeatenArtificer
            // 
            this.BeatenArtificer.AutoSize = true;
            this.BeatenArtificer.Controller = null;
            this.BeatenArtificer.IntegerIndex = 4;
            this.BeatenArtificer.Location = new System.Drawing.Point(198, 47);
            this.BeatenArtificer.Name = "BeatenArtificer";
            this.BeatenArtificer.Size = new System.Drawing.Size(107, 19);
            this.BeatenArtificer.TabIndex = 24;
            this.BeatenArtificer.TagQuery = "mpd@INTEGERSMSC/#";
            this.BeatenArtificer.Text = "Beaten Artificer";
            this.BeatenArtificer.UseVisualStyleBackColor = true;
            // 
            // BeatenGourmandFull
            // 
            this.BeatenGourmandFull.AutoSize = true;
            this.BeatenGourmandFull.CheckedValue = "2";
            this.BeatenGourmandFull.Controller = null;
            this.BeatenGourmandFull.IntegerIndex = 5;
            this.BeatenGourmandFull.Location = new System.Drawing.Point(198, 72);
            this.BeatenGourmandFull.Name = "BeatenGourmandFull";
            this.BeatenGourmandFull.Size = new System.Drawing.Size(142, 19);
            this.BeatenGourmandFull.TabIndex = 26;
            this.BeatenGourmandFull.TagQuery = "mpd@INTEGERSMSC/#";
            this.BeatenGourmandFull.Text = "Beaten Gourmand full";
            this.BeatenGourmandFull.UseVisualStyleBackColor = true;
            // 
            // BeatenGourmand
            // 
            this.BeatenGourmand.AutoSize = true;
            this.BeatenGourmand.Controller = null;
            this.BeatenGourmand.IntegerIndex = 5;
            this.BeatenGourmand.Location = new System.Drawing.Point(5, 72);
            this.BeatenGourmand.Name = "BeatenGourmand";
            this.BeatenGourmand.Size = new System.Drawing.Size(122, 19);
            this.BeatenGourmand.TabIndex = 25;
            this.BeatenGourmand.TagQuery = "mpd@INTEGERSMSC/#";
            this.BeatenGourmand.Text = "Beaten Gourmand";
            this.BeatenGourmand.UseVisualStyleBackColor = true;
            // 
            // BeatenSaint
            // 
            this.BeatenSaint.AutoSize = true;
            this.BeatenSaint.Controller = null;
            this.BeatenSaint.IntegerIndex = 7;
            this.BeatenSaint.Location = new System.Drawing.Point(198, 97);
            this.BeatenSaint.Name = "BeatenSaint";
            this.BeatenSaint.Size = new System.Drawing.Size(91, 19);
            this.BeatenSaint.TabIndex = 28;
            this.BeatenSaint.TagQuery = "mpd@INTEGERSMSC/#";
            this.BeatenSaint.Text = "Beaten Saint";
            this.BeatenSaint.UseVisualStyleBackColor = true;
            // 
            // BeatenRivulet
            // 
            this.BeatenRivulet.AutoSize = true;
            this.BeatenRivulet.Controller = null;
            this.BeatenRivulet.IntegerIndex = 6;
            this.BeatenRivulet.Location = new System.Drawing.Point(5, 97);
            this.BeatenRivulet.Name = "BeatenRivulet";
            this.BeatenRivulet.Size = new System.Drawing.Size(101, 19);
            this.BeatenRivulet.TabIndex = 27;
            this.BeatenRivulet.TagQuery = "mpd@INTEGERSMSC/#";
            this.BeatenRivulet.Text = "Beaten Rivulet";
            this.BeatenRivulet.UseVisualStyleBackColor = true;
            // 
            // BeatenHunter
            // 
            this.BeatenHunter.AutoSize = true;
            this.BeatenHunter.Controller = null;
            this.BeatenHunter.IntegerIndex = 9;
            this.BeatenHunter.Location = new System.Drawing.Point(198, 122);
            this.BeatenHunter.Name = "BeatenHunter";
            this.BeatenHunter.Size = new System.Drawing.Size(102, 19);
            this.BeatenHunter.TabIndex = 30;
            this.BeatenHunter.TagQuery = "mpd@INTEGERSMSC/#";
            this.BeatenHunter.Text = "Beaten Hunter";
            this.BeatenHunter.UseVisualStyleBackColor = true;
            // 
            // BeatenSurvivor
            // 
            this.BeatenSurvivor.AutoSize = true;
            this.BeatenSurvivor.Controller = null;
            this.BeatenSurvivor.IntegerIndex = 8;
            this.BeatenSurvivor.Location = new System.Drawing.Point(5, 122);
            this.BeatenSurvivor.Name = "BeatenSurvivor";
            this.BeatenSurvivor.Size = new System.Drawing.Size(108, 19);
            this.BeatenSurvivor.TabIndex = 29;
            this.BeatenSurvivor.TagQuery = "mpd@INTEGERSMSC/#";
            this.BeatenSurvivor.Text = "Beaten Survivor";
            this.BeatenSurvivor.UseVisualStyleBackColor = true;
            // 
            // MonkEnding
            // 
            this.MonkEnding.AutoSize = true;
            this.MonkEnding.Controller = null;
            this.MonkEnding.IntegerIndex = 11;
            this.MonkEnding.Location = new System.Drawing.Point(198, 147);
            this.MonkEnding.Name = "MonkEnding";
            this.MonkEnding.Size = new System.Drawing.Size(127, 19);
            this.MonkEnding.TabIndex = 32;
            this.MonkEnding.TagQuery = "mpd@INTEGERSMSC/#";
            this.MonkEnding.Text = "Monk coop ending";
            this.MonkEnding.UseVisualStyleBackColor = true;
            // 
            // SurvivorEnding
            // 
            this.SurvivorEnding.AutoSize = true;
            this.SurvivorEnding.Controller = null;
            this.SurvivorEnding.IntegerIndex = 10;
            this.SurvivorEnding.Location = new System.Drawing.Point(5, 147);
            this.SurvivorEnding.Name = "SurvivorEnding";
            this.SurvivorEnding.Size = new System.Drawing.Size(139, 19);
            this.SurvivorEnding.TabIndex = 31;
            this.SurvivorEnding.TagQuery = "mpd@INTEGERSMSC/#";
            this.SurvivorEnding.Text = "Survivor coop ending";
            this.SurvivorEnding.UseVisualStyleBackColor = true;
            // 
            // SurvivorPupsAtEnding
            // 
            this.SurvivorPupsAtEnding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SurvivorPupsAtEnding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurvivorPupsAtEnding.Controller = null;
            this.SurvivorPupsAtEnding.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SurvivorPupsAtEnding.IntegerIndex = 12;
            this.SurvivorPupsAtEnding.Location = new System.Drawing.Point(5, 189);
            this.SurvivorPupsAtEnding.Multiline = true;
            this.SurvivorPupsAtEnding.Name = "SurvivorPupsAtEnding";
            this.SurvivorPupsAtEnding.Size = new System.Drawing.Size(123, 19);
            this.SurvivorPupsAtEnding.TabIndex = 33;
            this.SurvivorPupsAtEnding.TagQuery = "mpd@INTEGERSMSC/#";
            this.SurvivorPupsAtEnding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SurvivorPupsAtEndingLabel
            // 
            this.SurvivorPupsAtEndingLabel.AutoSize = true;
            this.SurvivorPupsAtEndingLabel.Location = new System.Drawing.Point(3, 171);
            this.SurvivorPupsAtEndingLabel.Name = "SurvivorPupsAtEndingLabel";
            this.SurvivorPupsAtEndingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SurvivorPupsAtEndingLabel.Size = new System.Drawing.Size(132, 15);
            this.SurvivorPupsAtEndingLabel.TabIndex = 34;
            this.SurvivorPupsAtEndingLabel.Text = "Survivor pups at ending";
            // 
            // ArtificerEnding
            // 
            this.ArtificerEnding.AutoSize = true;
            this.ArtificerEnding.Controller = null;
            this.ArtificerEnding.IntegerIndex = 13;
            this.ArtificerEnding.Location = new System.Drawing.Point(198, 172);
            this.ArtificerEnding.Name = "ArtificerEnding";
            this.ArtificerEnding.Size = new System.Drawing.Size(138, 19);
            this.ArtificerEnding.TabIndex = 35;
            this.ArtificerEnding.TagQuery = "mpd@INTEGERSMSC/#";
            this.ArtificerEnding.Text = "Artificer coop ending";
            this.ArtificerEnding.UseVisualStyleBackColor = true;
            // 
            // MoreSlugcats
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.MainTagController);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MoreSlugcats";
            this.Size = new System.Drawing.Size(427, 214);
            this.MainTagController.ResumeLayout(false);
            this.MainTagController.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
