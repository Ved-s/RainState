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
    public class MiscProg : UserControl
    {
#nullable disable
        private TagWatchController MainTagController;
        private IntegersArrayCheckBox LookedForOlderVersionSaveFile;
        private IntegersArrayCheckBox RedVisitedPebbles;
        private IntegersArrayTextBox MeatEatingTutorialsInput;
        private IntegersArrayTextBox KarmaLossWarningsKarmaLossWarningsInput;
        private IntegersArrayTextBox StarvationTutorialInput;
        private IntegersArrayTextBox WatchedMalnourishScreensInput;
        private IntegersArrayTextBox WatchedDeathScreensWithFlowerInput;
        private IntegersArrayTextBox WatchedDeathScreensInput;
        private IntegersArrayTextBox WatchedSleepScreensInput;
        private IntegersArrayTextBox SelectedSlugcatInput;
        private IntegersArrayCheckBox RedUnlocked;
        private Label MeatEatingTutorialsLabel;
        private Label KarmaLossWarningsLabel;
        private Label StarvationTutorialLabel;
        private Label WatchedMalnourishScreensLabel;
        private Label WatchedDeathScreensWithFlowerLabel;
        private Label WatchedDeathScreensLabel;
        private Label WatchedSleepScreensLabel;
        private Label SelectedSlugcatLabel;
        private Label MenuRegionLabel;
        private TagTextBox MenuRegionInput;
#nullable restore

        public MiscProg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.MeatEatingTutorialsLabel = new System.Windows.Forms.Label();
            this.KarmaLossWarningsLabel = new System.Windows.Forms.Label();
            this.StarvationTutorialLabel = new System.Windows.Forms.Label();
            this.WatchedMalnourishScreensLabel = new System.Windows.Forms.Label();
            this.WatchedDeathScreensWithFlowerLabel = new System.Windows.Forms.Label();
            this.WatchedDeathScreensLabel = new System.Windows.Forms.Label();
            this.WatchedSleepScreensLabel = new System.Windows.Forms.Label();
            this.SelectedSlugcatLabel = new System.Windows.Forms.Label();
            this.MenuRegionLabel = new System.Windows.Forms.Label();
            this.MainTagController = new RainState.TagControls.TagWatchController();
            this.LookedForOlderVersionSaveFile = new RainState.TagControls.IntegersArrayCheckBox();
            this.RedVisitedPebbles = new RainState.TagControls.IntegersArrayCheckBox();
            this.MeatEatingTutorialsInput = new RainState.TagControls.IntegersArrayTextBox();
            this.KarmaLossWarningsKarmaLossWarningsInput = new RainState.TagControls.IntegersArrayTextBox();
            this.StarvationTutorialInput = new RainState.TagControls.IntegersArrayTextBox();
            this.WatchedMalnourishScreensInput = new RainState.TagControls.IntegersArrayTextBox();
            this.WatchedDeathScreensWithFlowerInput = new RainState.TagControls.IntegersArrayTextBox();
            this.WatchedDeathScreensInput = new RainState.TagControls.IntegersArrayTextBox();
            this.WatchedSleepScreensInput = new RainState.TagControls.IntegersArrayTextBox();
            this.SelectedSlugcatInput = new RainState.TagControls.IntegersArrayTextBox();
            this.RedUnlocked = new RainState.TagControls.IntegersArrayCheckBox();
            this.MenuRegionInput = new RainState.TagControls.TagTextBox();
            this.MainTagController.SuspendLayout();
            this.SuspendLayout();
            // 
            // MeatEatingTutorialsLabel
            // 
            this.MeatEatingTutorialsLabel.AutoSize = true;
            this.MeatEatingTutorialsLabel.Location = new System.Drawing.Point(208, 123);
            this.MeatEatingTutorialsLabel.Name = "MeatEatingTutorialsLabel";
            this.MeatEatingTutorialsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MeatEatingTutorialsLabel.Size = new System.Drawing.Size(116, 15);
            this.MeatEatingTutorialsLabel.TabIndex = 18;
            this.MeatEatingTutorialsLabel.Text = "Meat eating tutorials";
            // 
            // KarmaLossWarningsLabel
            // 
            this.KarmaLossWarningsLabel.AutoSize = true;
            this.KarmaLossWarningsLabel.Location = new System.Drawing.Point(208, 83);
            this.KarmaLossWarningsLabel.Name = "KarmaLossWarningsLabel";
            this.KarmaLossWarningsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KarmaLossWarningsLabel.Size = new System.Drawing.Size(115, 15);
            this.KarmaLossWarningsLabel.TabIndex = 16;
            this.KarmaLossWarningsLabel.Text = "Karma loss warnings";
            // 
            // StarvationTutorialLabel
            // 
            this.StarvationTutorialLabel.AutoSize = true;
            this.StarvationTutorialLabel.Location = new System.Drawing.Point(208, 43);
            this.StarvationTutorialLabel.Name = "StarvationTutorialLabel";
            this.StarvationTutorialLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StarvationTutorialLabel.Size = new System.Drawing.Size(106, 15);
            this.StarvationTutorialLabel.TabIndex = 14;
            this.StarvationTutorialLabel.Text = "Starvation tutorials";
            // 
            // WatchedMalnourishScreensLabel
            // 
            this.WatchedMalnourishScreensLabel.AutoSize = true;
            this.WatchedMalnourishScreensLabel.Location = new System.Drawing.Point(3, 163);
            this.WatchedMalnourishScreensLabel.Name = "WatchedMalnourishScreensLabel";
            this.WatchedMalnourishScreensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WatchedMalnourishScreensLabel.Size = new System.Drawing.Size(159, 15);
            this.WatchedMalnourishScreensLabel.TabIndex = 12;
            this.WatchedMalnourishScreensLabel.Text = "Watched malnourish screens";
            // 
            // WatchedDeathScreensWithFlowerLabel
            // 
            this.WatchedDeathScreensWithFlowerLabel.AutoSize = true;
            this.WatchedDeathScreensWithFlowerLabel.Location = new System.Drawing.Point(3, 123);
            this.WatchedDeathScreensWithFlowerLabel.Name = "WatchedDeathScreensWithFlowerLabel";
            this.WatchedDeathScreensWithFlowerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WatchedDeathScreensWithFlowerLabel.Size = new System.Drawing.Size(191, 15);
            this.WatchedDeathScreensWithFlowerLabel.TabIndex = 10;
            this.WatchedDeathScreensWithFlowerLabel.Text = "Watched death screens with flower";
            // 
            // WatchedDeathScreensLabel
            // 
            this.WatchedDeathScreensLabel.AutoSize = true;
            this.WatchedDeathScreensLabel.Location = new System.Drawing.Point(3, 83);
            this.WatchedDeathScreensLabel.Name = "WatchedDeathScreensLabel";
            this.WatchedDeathScreensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WatchedDeathScreensLabel.Size = new System.Drawing.Size(129, 15);
            this.WatchedDeathScreensLabel.TabIndex = 8;
            this.WatchedDeathScreensLabel.Text = "Watched death screens";
            // 
            // WatchedSleepScreensLabel
            // 
            this.WatchedSleepScreensLabel.AutoSize = true;
            this.WatchedSleepScreensLabel.Location = new System.Drawing.Point(3, 43);
            this.WatchedSleepScreensLabel.Name = "WatchedSleepScreensLabel";
            this.WatchedSleepScreensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WatchedSleepScreensLabel.Size = new System.Drawing.Size(126, 15);
            this.WatchedSleepScreensLabel.TabIndex = 6;
            this.WatchedSleepScreensLabel.Text = "Watched sleep screens";
            // 
            // SelectedSlugcatLabel
            // 
            this.SelectedSlugcatLabel.AutoSize = true;
            this.SelectedSlugcatLabel.Location = new System.Drawing.Point(95, 3);
            this.SelectedSlugcatLabel.Name = "SelectedSlugcatLabel";
            this.SelectedSlugcatLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectedSlugcatLabel.Size = new System.Drawing.Size(92, 15);
            this.SelectedSlugcatLabel.TabIndex = 4;
            this.SelectedSlugcatLabel.Text = "Selected slugcat";
            // 
            // MenuRegionLabel
            // 
            this.MenuRegionLabel.AutoSize = true;
            this.MenuRegionLabel.Location = new System.Drawing.Point(2, 3);
            this.MenuRegionLabel.Name = "MenuRegionLabel";
            this.MenuRegionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuRegionLabel.Size = new System.Drawing.Size(75, 15);
            this.MenuRegionLabel.TabIndex = 1;
            this.MenuRegionLabel.Text = "Menu region";
            // 
            // MainTagController
            // 
            this.MainTagController.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainTagController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MainTagController.Controller = null;
            this.MainTagController.Controls.Add(this.LookedForOlderVersionSaveFile);
            this.MainTagController.Controls.Add(this.RedVisitedPebbles);
            this.MainTagController.Controls.Add(this.MeatEatingTutorialsInput);
            this.MainTagController.Controls.Add(this.MeatEatingTutorialsLabel);
            this.MainTagController.Controls.Add(this.KarmaLossWarningsKarmaLossWarningsInput);
            this.MainTagController.Controls.Add(this.KarmaLossWarningsLabel);
            this.MainTagController.Controls.Add(this.StarvationTutorialInput);
            this.MainTagController.Controls.Add(this.StarvationTutorialLabel);
            this.MainTagController.Controls.Add(this.WatchedMalnourishScreensInput);
            this.MainTagController.Controls.Add(this.WatchedMalnourishScreensLabel);
            this.MainTagController.Controls.Add(this.WatchedDeathScreensWithFlowerInput);
            this.MainTagController.Controls.Add(this.WatchedDeathScreensWithFlowerLabel);
            this.MainTagController.Controls.Add(this.WatchedDeathScreensInput);
            this.MainTagController.Controls.Add(this.WatchedDeathScreensLabel);
            this.MainTagController.Controls.Add(this.WatchedSleepScreensInput);
            this.MainTagController.Controls.Add(this.WatchedSleepScreensLabel);
            this.MainTagController.Controls.Add(this.SelectedSlugcatInput);
            this.MainTagController.Controls.Add(this.SelectedSlugcatLabel);
            this.MainTagController.Controls.Add(this.RedUnlocked);
            this.MainTagController.Controls.Add(this.MenuRegionInput);
            this.MainTagController.Controls.Add(this.MenuRegionLabel);
            this.MainTagController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTagController.Location = new System.Drawing.Point(0, 0);
            this.MainTagController.MainController = false;
            this.MainTagController.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.MainTagController.Name = "MainTagController";
            this.MainTagController.Size = new System.Drawing.Size(539, 251);
            this.MainTagController.TabIndex = 0;
            this.MainTagController.WatchQuery = "progDiv@MISCPROG/mpd$";
            // 
            // LookedForOlderVersionSaveFile
            // 
            this.LookedForOlderVersionSaveFile.AutoSize = true;
            this.LookedForOlderVersionSaveFile.Controller = null;
            this.LookedForOlderVersionSaveFile.IntegerIndex = 9;
            this.LookedForOlderVersionSaveFile.Location = new System.Drawing.Point(5, 231);
            this.LookedForOlderVersionSaveFile.Name = "LookedForOlderVersionSaveFile";
            this.LookedForOlderVersionSaveFile.Size = new System.Drawing.Size(199, 19);
            this.LookedForOlderVersionSaveFile.TabIndex = 20;
            this.LookedForOlderVersionSaveFile.TagQuery = "mpd@INTEGERS/#";
            this.LookedForOlderVersionSaveFile.Text = "Looked for older version save file";
            this.LookedForOlderVersionSaveFile.UseVisualStyleBackColor = true;
            // 
            // RedVisitedPebbles
            // 
            this.RedVisitedPebbles.AutoSize = true;
            this.RedVisitedPebbles.Controller = null;
            this.RedVisitedPebbles.IntegerIndex = 7;
            this.RedVisitedPebbles.Location = new System.Drawing.Point(5, 206);
            this.RedVisitedPebbles.Name = "RedVisitedPebbles";
            this.RedVisitedPebbles.Size = new System.Drawing.Size(144, 19);
            this.RedVisitedPebbles.TabIndex = 19;
            this.RedVisitedPebbles.TagQuery = "mpd@INTEGERS/#";
            this.RedVisitedPebbles.Text = "Hunter visited Pebbles";
            this.RedVisitedPebbles.UseVisualStyleBackColor = true;
            // 
            // MeatEatingTutorialsInput
            // 
            this.MeatEatingTutorialsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.MeatEatingTutorialsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeatEatingTutorialsInput.Controller = null;
            this.MeatEatingTutorialsInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeatEatingTutorialsInput.IntegerIndex = 10;
            this.MeatEatingTutorialsInput.Location = new System.Drawing.Point(211, 141);
            this.MeatEatingTutorialsInput.Multiline = true;
            this.MeatEatingTutorialsInput.Name = "MeatEatingTutorialsInput";
            this.MeatEatingTutorialsInput.Size = new System.Drawing.Size(123, 19);
            this.MeatEatingTutorialsInput.TabIndex = 17;
            this.MeatEatingTutorialsInput.TagQuery = "mpd@INTEGERS/#";
            this.MeatEatingTutorialsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KarmaLossWarningsKarmaLossWarningsInput
            // 
            this.KarmaLossWarningsKarmaLossWarningsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.KarmaLossWarningsKarmaLossWarningsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KarmaLossWarningsKarmaLossWarningsInput.Controller = null;
            this.KarmaLossWarningsKarmaLossWarningsInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KarmaLossWarningsKarmaLossWarningsInput.IntegerIndex = 6;
            this.KarmaLossWarningsKarmaLossWarningsInput.Location = new System.Drawing.Point(211, 101);
            this.KarmaLossWarningsKarmaLossWarningsInput.Multiline = true;
            this.KarmaLossWarningsKarmaLossWarningsInput.Name = "KarmaLossWarningsKarmaLossWarningsInput";
            this.KarmaLossWarningsKarmaLossWarningsInput.Size = new System.Drawing.Size(123, 19);
            this.KarmaLossWarningsKarmaLossWarningsInput.TabIndex = 15;
            this.KarmaLossWarningsKarmaLossWarningsInput.TagQuery = "mpd@INTEGERS/#";
            this.KarmaLossWarningsKarmaLossWarningsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarvationTutorialInput
            // 
            this.StarvationTutorialInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.StarvationTutorialInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StarvationTutorialInput.Controller = null;
            this.StarvationTutorialInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StarvationTutorialInput.IntegerIndex = 5;
            this.StarvationTutorialInput.Location = new System.Drawing.Point(211, 61);
            this.StarvationTutorialInput.Multiline = true;
            this.StarvationTutorialInput.Name = "StarvationTutorialInput";
            this.StarvationTutorialInput.Size = new System.Drawing.Size(123, 19);
            this.StarvationTutorialInput.TabIndex = 13;
            this.StarvationTutorialInput.TagQuery = "mpd@INTEGERS/#";
            this.StarvationTutorialInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WatchedMalnourishScreensInput
            // 
            this.WatchedMalnourishScreensInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.WatchedMalnourishScreensInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WatchedMalnourishScreensInput.Controller = null;
            this.WatchedMalnourishScreensInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WatchedMalnourishScreensInput.IntegerIndex = 4;
            this.WatchedMalnourishScreensInput.Location = new System.Drawing.Point(5, 181);
            this.WatchedMalnourishScreensInput.Multiline = true;
            this.WatchedMalnourishScreensInput.Name = "WatchedMalnourishScreensInput";
            this.WatchedMalnourishScreensInput.Size = new System.Drawing.Size(123, 19);
            this.WatchedMalnourishScreensInput.TabIndex = 11;
            this.WatchedMalnourishScreensInput.TagQuery = "mpd@INTEGERS/#";
            this.WatchedMalnourishScreensInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WatchedDeathScreensWithFlowerInput
            // 
            this.WatchedDeathScreensWithFlowerInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.WatchedDeathScreensWithFlowerInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WatchedDeathScreensWithFlowerInput.Controller = null;
            this.WatchedDeathScreensWithFlowerInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WatchedDeathScreensWithFlowerInput.IntegerIndex = 3;
            this.WatchedDeathScreensWithFlowerInput.Location = new System.Drawing.Point(5, 141);
            this.WatchedDeathScreensWithFlowerInput.Multiline = true;
            this.WatchedDeathScreensWithFlowerInput.Name = "WatchedDeathScreensWithFlowerInput";
            this.WatchedDeathScreensWithFlowerInput.Size = new System.Drawing.Size(123, 19);
            this.WatchedDeathScreensWithFlowerInput.TabIndex = 9;
            this.WatchedDeathScreensWithFlowerInput.TagQuery = "mpd@INTEGERS/#";
            this.WatchedDeathScreensWithFlowerInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WatchedDeathScreensInput
            // 
            this.WatchedDeathScreensInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.WatchedDeathScreensInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WatchedDeathScreensInput.Controller = null;
            this.WatchedDeathScreensInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WatchedDeathScreensInput.IntegerIndex = 2;
            this.WatchedDeathScreensInput.Location = new System.Drawing.Point(5, 101);
            this.WatchedDeathScreensInput.Multiline = true;
            this.WatchedDeathScreensInput.Name = "WatchedDeathScreensInput";
            this.WatchedDeathScreensInput.Size = new System.Drawing.Size(123, 19);
            this.WatchedDeathScreensInput.TabIndex = 7;
            this.WatchedDeathScreensInput.TagQuery = "mpd@INTEGERS/#";
            this.WatchedDeathScreensInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WatchedSleepScreensInput
            // 
            this.WatchedSleepScreensInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.WatchedSleepScreensInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WatchedSleepScreensInput.Controller = null;
            this.WatchedSleepScreensInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WatchedSleepScreensInput.IntegerIndex = 1;
            this.WatchedSleepScreensInput.Location = new System.Drawing.Point(5, 61);
            this.WatchedSleepScreensInput.Multiline = true;
            this.WatchedSleepScreensInput.Name = "WatchedSleepScreensInput";
            this.WatchedSleepScreensInput.Size = new System.Drawing.Size(123, 19);
            this.WatchedSleepScreensInput.TabIndex = 5;
            this.WatchedSleepScreensInput.TagQuery = "mpd@INTEGERS/#";
            this.WatchedSleepScreensInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectedSlugcatInput
            // 
            this.SelectedSlugcatInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SelectedSlugcatInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedSlugcatInput.Controller = null;
            this.SelectedSlugcatInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectedSlugcatInput.IntegerIndex = 0;
            this.SelectedSlugcatInput.Location = new System.Drawing.Point(98, 21);
            this.SelectedSlugcatInput.Multiline = true;
            this.SelectedSlugcatInput.Name = "SelectedSlugcatInput";
            this.SelectedSlugcatInput.Size = new System.Drawing.Size(89, 19);
            this.SelectedSlugcatInput.TabIndex = 3;
            this.SelectedSlugcatInput.TagQuery = "mpd@INTEGERS/#";
            this.SelectedSlugcatInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RedUnlocked
            // 
            this.RedUnlocked.AutoSize = true;
            this.RedUnlocked.Controller = null;
            this.RedUnlocked.IntegerIndex = 8;
            this.RedUnlocked.Location = new System.Drawing.Point(165, 206);
            this.RedUnlocked.Name = "RedUnlocked";
            this.RedUnlocked.Size = new System.Drawing.Size(115, 19);
            this.RedUnlocked.TabIndex = 2;
            this.RedUnlocked.TagQuery = "mpd@INTEGERS/#";
            this.RedUnlocked.Text = "Hunter unlocked";
            this.RedUnlocked.UseVisualStyleBackColor = true;
            // 
            // MenuRegionInput
            // 
            this.MenuRegionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.MenuRegionInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuRegionInput.Controller = null;
            this.MenuRegionInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuRegionInput.Location = new System.Drawing.Point(5, 21);
            this.MenuRegionInput.Multiline = true;
            this.MenuRegionInput.Name = "MenuRegionInput";
            this.MenuRegionInput.Size = new System.Drawing.Size(89, 19);
            this.MenuRegionInput.TabIndex = 0;
            this.MenuRegionInput.TagQuery = "mpd@MENUREGION/#";
            this.MenuRegionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MiscProg
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.MainTagController);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MiscProg";
            this.Size = new System.Drawing.Size(539, 251);
            this.MainTagController.ResumeLayout(false);
            this.MainTagController.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
