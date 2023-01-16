using RainState.TagControls;

namespace RainState.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Miscprog_MenuRegionLabel;
            System.Windows.Forms.Label Miscprog_SelectedSlugcatLabel;
            System.Windows.Forms.Label Miscprog_WatchedSleepScreensLabel;
            System.Windows.Forms.Label Miscprog_WatchedDeathScreensLabel;
            System.Windows.Forms.Label Miscprog_WatchedDeathScreensWithFlowerLabel;
            System.Windows.Forms.Label Miscprog_WatchedMalnourishScreensLabel;
            System.Windows.Forms.Label Miscprog_MeatEatingTutorialsLabel;
            System.Windows.Forms.Label Miscprog_KarmaLossWarningsLabel;
            System.Windows.Forms.Label Miscprog_StarvationTutorialLabel;
            this.StateTree = new System.Windows.Forms.TreeView();
            this.SplitH = new System.Windows.Forms.SplitContainer();
            this.MainTagController = new RainState.TagControls.TagWatchController();
            this.MiscprogGroup = new System.Windows.Forms.GroupBox();
            this.TagMiscprogController = new RainState.TagControls.TagWatchController();
            this.Miscprog_LookedForOlderVersionSaveFile = new RainState.TagControls.IntegersArrayCheckBox();
            this.Miscprog_RedVisitedPebbles = new RainState.TagControls.IntegersArrayCheckBox();
            this.Miscprog_MeatEatingTutorialsInput = new RainState.TagControls.IntegersArrayTextBox();
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput = new RainState.TagControls.IntegersArrayTextBox();
            this.Miscprog_StarvationTutorialInput = new RainState.TagControls.IntegersArrayTextBox();
            this.Miscprog_WatchedMalnourishScreensInput = new RainState.TagControls.IntegersArrayTextBox();
            this.Miscprog_WatchedDeathScreensWithFlowerInput = new RainState.TagControls.IntegersArrayTextBox();
            this.Miscprog_WatchedDeathScreensInput = new RainState.TagControls.IntegersArrayTextBox();
            this.Miscprog_WatchedSleepScreensInput = new RainState.TagControls.IntegersArrayTextBox();
            this.Miscprog_SelectedSlugcatInput = new RainState.TagControls.IntegersArrayTextBox();
            this.Miscprog_RedUnlocked = new RainState.TagControls.IntegersArrayCheckBox();
            this.Miscprog_MenuRegionInput = new RainState.TagControls.TagTextBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            Miscprog_MenuRegionLabel = new System.Windows.Forms.Label();
            Miscprog_SelectedSlugcatLabel = new System.Windows.Forms.Label();
            Miscprog_WatchedSleepScreensLabel = new System.Windows.Forms.Label();
            Miscprog_WatchedDeathScreensLabel = new System.Windows.Forms.Label();
            Miscprog_WatchedDeathScreensWithFlowerLabel = new System.Windows.Forms.Label();
            Miscprog_WatchedMalnourishScreensLabel = new System.Windows.Forms.Label();
            Miscprog_MeatEatingTutorialsLabel = new System.Windows.Forms.Label();
            Miscprog_KarmaLossWarningsLabel = new System.Windows.Forms.Label();
            Miscprog_StarvationTutorialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplitH)).BeginInit();
            this.SplitH.Panel1.SuspendLayout();
            this.SplitH.Panel2.SuspendLayout();
            this.SplitH.SuspendLayout();
            this.MainTagController.SuspendLayout();
            this.MiscprogGroup.SuspendLayout();
            this.TagMiscprogController.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Miscprog_MenuRegionLabel
            // 
            Miscprog_MenuRegionLabel.AutoSize = true;
            Miscprog_MenuRegionLabel.Location = new System.Drawing.Point(3, 3);
            Miscprog_MenuRegionLabel.Name = "Miscprog_MenuRegionLabel";
            Miscprog_MenuRegionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Miscprog_MenuRegionLabel.Size = new System.Drawing.Size(75, 15);
            Miscprog_MenuRegionLabel.TabIndex = 1;
            Miscprog_MenuRegionLabel.Text = "Menu region";
            // 
            // Miscprog_SelectedSlugcatLabel
            // 
            Miscprog_SelectedSlugcatLabel.AutoSize = true;
            Miscprog_SelectedSlugcatLabel.Location = new System.Drawing.Point(95, 3);
            Miscprog_SelectedSlugcatLabel.Name = "Miscprog_SelectedSlugcatLabel";
            Miscprog_SelectedSlugcatLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Miscprog_SelectedSlugcatLabel.Size = new System.Drawing.Size(92, 15);
            Miscprog_SelectedSlugcatLabel.TabIndex = 4;
            Miscprog_SelectedSlugcatLabel.Text = "Selected slugcat";
            // 
            // Miscprog_WatchedSleepScreensLabel
            // 
            Miscprog_WatchedSleepScreensLabel.AutoSize = true;
            Miscprog_WatchedSleepScreensLabel.Location = new System.Drawing.Point(3, 50);
            Miscprog_WatchedSleepScreensLabel.Name = "Miscprog_WatchedSleepScreensLabel";
            Miscprog_WatchedSleepScreensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Miscprog_WatchedSleepScreensLabel.Size = new System.Drawing.Size(126, 15);
            Miscprog_WatchedSleepScreensLabel.TabIndex = 6;
            Miscprog_WatchedSleepScreensLabel.Text = "Watched sleep screens";
            // 
            // Miscprog_WatchedDeathScreensLabel
            // 
            Miscprog_WatchedDeathScreensLabel.AutoSize = true;
            Miscprog_WatchedDeathScreensLabel.Location = new System.Drawing.Point(3, 89);
            Miscprog_WatchedDeathScreensLabel.Name = "Miscprog_WatchedDeathScreensLabel";
            Miscprog_WatchedDeathScreensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Miscprog_WatchedDeathScreensLabel.Size = new System.Drawing.Size(129, 15);
            Miscprog_WatchedDeathScreensLabel.TabIndex = 8;
            Miscprog_WatchedDeathScreensLabel.Text = "Watched death screens";
            // 
            // Miscprog_WatchedDeathScreensWithFlowerLabel
            // 
            Miscprog_WatchedDeathScreensWithFlowerLabel.AutoSize = true;
            Miscprog_WatchedDeathScreensWithFlowerLabel.Location = new System.Drawing.Point(3, 128);
            Miscprog_WatchedDeathScreensWithFlowerLabel.Name = "Miscprog_WatchedDeathScreensWithFlowerLabel";
            Miscprog_WatchedDeathScreensWithFlowerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Miscprog_WatchedDeathScreensWithFlowerLabel.Size = new System.Drawing.Size(191, 15);
            Miscprog_WatchedDeathScreensWithFlowerLabel.TabIndex = 10;
            Miscprog_WatchedDeathScreensWithFlowerLabel.Text = "Watched death screens with flower";
            // 
            // Miscprog_WatchedMalnourishScreensLabel
            // 
            Miscprog_WatchedMalnourishScreensLabel.AutoSize = true;
            Miscprog_WatchedMalnourishScreensLabel.Location = new System.Drawing.Point(3, 167);
            Miscprog_WatchedMalnourishScreensLabel.Name = "Miscprog_WatchedMalnourishScreensLabel";
            Miscprog_WatchedMalnourishScreensLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Miscprog_WatchedMalnourishScreensLabel.Size = new System.Drawing.Size(159, 15);
            Miscprog_WatchedMalnourishScreensLabel.TabIndex = 12;
            Miscprog_WatchedMalnourishScreensLabel.Text = "Watched malnourish screens";
            // 
            // Miscprog_MeatEatingTutorialsLabel
            // 
            Miscprog_MeatEatingTutorialsLabel.AutoSize = true;
            Miscprog_MeatEatingTutorialsLabel.Location = new System.Drawing.Point(200, 128);
            Miscprog_MeatEatingTutorialsLabel.Name = "Miscprog_MeatEatingTutorialsLabel";
            Miscprog_MeatEatingTutorialsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Miscprog_MeatEatingTutorialsLabel.Size = new System.Drawing.Size(116, 15);
            Miscprog_MeatEatingTutorialsLabel.TabIndex = 18;
            Miscprog_MeatEatingTutorialsLabel.Text = "Meat eating tutorials";
            // 
            // Miscprog_KarmaLossWarningsLabel
            // 
            Miscprog_KarmaLossWarningsLabel.AutoSize = true;
            Miscprog_KarmaLossWarningsLabel.Location = new System.Drawing.Point(200, 89);
            Miscprog_KarmaLossWarningsLabel.Name = "Miscprog_KarmaLossWarningsLabel";
            Miscprog_KarmaLossWarningsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Miscprog_KarmaLossWarningsLabel.Size = new System.Drawing.Size(115, 15);
            Miscprog_KarmaLossWarningsLabel.TabIndex = 16;
            Miscprog_KarmaLossWarningsLabel.Text = "Karma loss warnings";
            // 
            // Miscprog_StarvationTutorialLabel
            // 
            Miscprog_StarvationTutorialLabel.AutoSize = true;
            Miscprog_StarvationTutorialLabel.Location = new System.Drawing.Point(200, 50);
            Miscprog_StarvationTutorialLabel.Name = "Miscprog_StarvationTutorialLabel";
            Miscprog_StarvationTutorialLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Miscprog_StarvationTutorialLabel.Size = new System.Drawing.Size(106, 15);
            Miscprog_StarvationTutorialLabel.TabIndex = 14;
            Miscprog_StarvationTutorialLabel.Text = "Starvation tutorials";
            // 
            // StateTree
            // 
            this.StateTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.StateTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateTree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StateTree.Location = new System.Drawing.Point(0, 0);
            this.StateTree.Name = "StateTree";
            this.StateTree.Size = new System.Drawing.Size(266, 426);
            this.StateTree.TabIndex = 0;
            // 
            // SplitH
            // 
            this.SplitH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitH.Location = new System.Drawing.Point(0, 24);
            this.SplitH.Name = "SplitH";
            // 
            // SplitH.Panel1
            // 
            this.SplitH.Panel1.Controls.Add(this.StateTree);
            // 
            // SplitH.Panel2
            // 
            this.SplitH.Panel2.Controls.Add(this.MainTagController);
            this.SplitH.Size = new System.Drawing.Size(800, 426);
            this.SplitH.SplitterDistance = 266;
            this.SplitH.TabIndex = 1;
            // 
            // MainTagController
            // 
            this.MainTagController.Controller = null;
            this.MainTagController.Controls.Add(this.MiscprogGroup);
            this.MainTagController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTagController.Location = new System.Drawing.Point(0, 0);
            this.MainTagController.MainController = false;
            this.MainTagController.Name = "MainTagController";
            this.MainTagController.Size = new System.Drawing.Size(530, 426);
            this.MainTagController.TabIndex = 0;
            this.MainTagController.WatchQuery = "";
            // 
            // MiscprogGroup
            // 
            this.MiscprogGroup.Controls.Add(this.TagMiscprogController);
            this.MiscprogGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiscprogGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MiscprogGroup.Location = new System.Drawing.Point(0, 0);
            this.MiscprogGroup.Name = "MiscprogGroup";
            this.MiscprogGroup.Size = new System.Drawing.Size(530, 287);
            this.MiscprogGroup.TabIndex = 0;
            this.MiscprogGroup.TabStop = false;
            this.MiscprogGroup.Text = "Misc progression data";
            // 
            // TagMiscprogController
            // 
            this.TagMiscprogController.Controller = null;
            this.TagMiscprogController.Controls.Add(this.Miscprog_LookedForOlderVersionSaveFile);
            this.TagMiscprogController.Controls.Add(this.Miscprog_RedVisitedPebbles);
            this.TagMiscprogController.Controls.Add(this.Miscprog_MeatEatingTutorialsInput);
            this.TagMiscprogController.Controls.Add(Miscprog_MeatEatingTutorialsLabel);
            this.TagMiscprogController.Controls.Add(this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput);
            this.TagMiscprogController.Controls.Add(Miscprog_KarmaLossWarningsLabel);
            this.TagMiscprogController.Controls.Add(this.Miscprog_StarvationTutorialInput);
            this.TagMiscprogController.Controls.Add(Miscprog_StarvationTutorialLabel);
            this.TagMiscprogController.Controls.Add(this.Miscprog_WatchedMalnourishScreensInput);
            this.TagMiscprogController.Controls.Add(Miscprog_WatchedMalnourishScreensLabel);
            this.TagMiscprogController.Controls.Add(this.Miscprog_WatchedDeathScreensWithFlowerInput);
            this.TagMiscprogController.Controls.Add(Miscprog_WatchedDeathScreensWithFlowerLabel);
            this.TagMiscprogController.Controls.Add(this.Miscprog_WatchedDeathScreensInput);
            this.TagMiscprogController.Controls.Add(Miscprog_WatchedDeathScreensLabel);
            this.TagMiscprogController.Controls.Add(this.Miscprog_WatchedSleepScreensInput);
            this.TagMiscprogController.Controls.Add(Miscprog_WatchedSleepScreensLabel);
            this.TagMiscprogController.Controls.Add(this.Miscprog_SelectedSlugcatInput);
            this.TagMiscprogController.Controls.Add(Miscprog_SelectedSlugcatLabel);
            this.TagMiscprogController.Controls.Add(this.Miscprog_RedUnlocked);
            this.TagMiscprogController.Controls.Add(this.Miscprog_MenuRegionInput);
            this.TagMiscprogController.Controls.Add(Miscprog_MenuRegionLabel);
            this.TagMiscprogController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TagMiscprogController.Location = new System.Drawing.Point(3, 19);
            this.TagMiscprogController.MainController = false;
            this.TagMiscprogController.Name = "TagMiscprogController";
            this.TagMiscprogController.Size = new System.Drawing.Size(524, 265);
            this.TagMiscprogController.TabIndex = 0;
            this.TagMiscprogController.WatchQuery = "progDiv@MISCPROG/mpd$";
            // 
            // Miscprog_LookedForOlderVersionSaveFile
            // 
            this.Miscprog_LookedForOlderVersionSaveFile.AutoSize = true;
            this.Miscprog_LookedForOlderVersionSaveFile.Controller = null;
            this.Miscprog_LookedForOlderVersionSaveFile.IntegerIndex = 9;
            this.Miscprog_LookedForOlderVersionSaveFile.Location = new System.Drawing.Point(6, 245);
            this.Miscprog_LookedForOlderVersionSaveFile.Name = "Miscprog_LookedForOlderVersionSaveFile";
            this.Miscprog_LookedForOlderVersionSaveFile.Size = new System.Drawing.Size(199, 19);
            this.Miscprog_LookedForOlderVersionSaveFile.TabIndex = 20;
            this.Miscprog_LookedForOlderVersionSaveFile.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_LookedForOlderVersionSaveFile.Text = "Looked for older version save file";
            this.Miscprog_LookedForOlderVersionSaveFile.UseVisualStyleBackColor = true;
            // 
            // Miscprog_RedVisitedPebbles
            // 
            this.Miscprog_RedVisitedPebbles.AutoSize = true;
            this.Miscprog_RedVisitedPebbles.Controller = null;
            this.Miscprog_RedVisitedPebbles.IntegerIndex = 7;
            this.Miscprog_RedVisitedPebbles.Location = new System.Drawing.Point(6, 220);
            this.Miscprog_RedVisitedPebbles.Name = "Miscprog_RedVisitedPebbles";
            this.Miscprog_RedVisitedPebbles.Size = new System.Drawing.Size(144, 19);
            this.Miscprog_RedVisitedPebbles.TabIndex = 19;
            this.Miscprog_RedVisitedPebbles.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_RedVisitedPebbles.Text = "Hunter visited Pebbles";
            this.Miscprog_RedVisitedPebbles.UseVisualStyleBackColor = true;
            // 
            // Miscprog_MeatEatingTutorialsInput
            // 
            this.Miscprog_MeatEatingTutorialsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Miscprog_MeatEatingTutorialsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Miscprog_MeatEatingTutorialsInput.Controller = null;
            this.Miscprog_MeatEatingTutorialsInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Miscprog_MeatEatingTutorialsInput.IntegerIndex = 10;
            this.Miscprog_MeatEatingTutorialsInput.Location = new System.Drawing.Point(203, 146);
            this.Miscprog_MeatEatingTutorialsInput.Multiline = true;
            this.Miscprog_MeatEatingTutorialsInput.Name = "Miscprog_MeatEatingTutorialsInput";
            this.Miscprog_MeatEatingTutorialsInput.Size = new System.Drawing.Size(123, 19);
            this.Miscprog_MeatEatingTutorialsInput.TabIndex = 17;
            this.Miscprog_MeatEatingTutorialsInput.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_MeatEatingTutorialsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Miscprog_KarmaLossWarningsKarmaLossWarningsInput
            // 
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.Controller = null;
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.IntegerIndex = 6;
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.Location = new System.Drawing.Point(203, 107);
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.Multiline = true;
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.Name = "Miscprog_KarmaLossWarningsKarmaLossWarningsInput";
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.Size = new System.Drawing.Size(123, 19);
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.TabIndex = 15;
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_KarmaLossWarningsKarmaLossWarningsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Miscprog_StarvationTutorialInput
            // 
            this.Miscprog_StarvationTutorialInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Miscprog_StarvationTutorialInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Miscprog_StarvationTutorialInput.Controller = null;
            this.Miscprog_StarvationTutorialInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Miscprog_StarvationTutorialInput.IntegerIndex = 5;
            this.Miscprog_StarvationTutorialInput.Location = new System.Drawing.Point(203, 68);
            this.Miscprog_StarvationTutorialInput.Multiline = true;
            this.Miscprog_StarvationTutorialInput.Name = "Miscprog_StarvationTutorialInput";
            this.Miscprog_StarvationTutorialInput.Size = new System.Drawing.Size(123, 19);
            this.Miscprog_StarvationTutorialInput.TabIndex = 13;
            this.Miscprog_StarvationTutorialInput.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_StarvationTutorialInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Miscprog_WatchedMalnourishScreensInput
            // 
            this.Miscprog_WatchedMalnourishScreensInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Miscprog_WatchedMalnourishScreensInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Miscprog_WatchedMalnourishScreensInput.Controller = null;
            this.Miscprog_WatchedMalnourishScreensInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Miscprog_WatchedMalnourishScreensInput.IntegerIndex = 4;
            this.Miscprog_WatchedMalnourishScreensInput.Location = new System.Drawing.Point(6, 185);
            this.Miscprog_WatchedMalnourishScreensInput.Multiline = true;
            this.Miscprog_WatchedMalnourishScreensInput.Name = "Miscprog_WatchedMalnourishScreensInput";
            this.Miscprog_WatchedMalnourishScreensInput.Size = new System.Drawing.Size(123, 19);
            this.Miscprog_WatchedMalnourishScreensInput.TabIndex = 11;
            this.Miscprog_WatchedMalnourishScreensInput.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_WatchedMalnourishScreensInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Miscprog_WatchedDeathScreensWithFlowerInput
            // 
            this.Miscprog_WatchedDeathScreensWithFlowerInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Miscprog_WatchedDeathScreensWithFlowerInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Miscprog_WatchedDeathScreensWithFlowerInput.Controller = null;
            this.Miscprog_WatchedDeathScreensWithFlowerInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Miscprog_WatchedDeathScreensWithFlowerInput.IntegerIndex = 3;
            this.Miscprog_WatchedDeathScreensWithFlowerInput.Location = new System.Drawing.Point(6, 146);
            this.Miscprog_WatchedDeathScreensWithFlowerInput.Multiline = true;
            this.Miscprog_WatchedDeathScreensWithFlowerInput.Name = "Miscprog_WatchedDeathScreensWithFlowerInput";
            this.Miscprog_WatchedDeathScreensWithFlowerInput.Size = new System.Drawing.Size(123, 19);
            this.Miscprog_WatchedDeathScreensWithFlowerInput.TabIndex = 9;
            this.Miscprog_WatchedDeathScreensWithFlowerInput.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_WatchedDeathScreensWithFlowerInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Miscprog_WatchedDeathScreensInput
            // 
            this.Miscprog_WatchedDeathScreensInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Miscprog_WatchedDeathScreensInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Miscprog_WatchedDeathScreensInput.Controller = null;
            this.Miscprog_WatchedDeathScreensInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Miscprog_WatchedDeathScreensInput.IntegerIndex = 2;
            this.Miscprog_WatchedDeathScreensInput.Location = new System.Drawing.Point(6, 107);
            this.Miscprog_WatchedDeathScreensInput.Multiline = true;
            this.Miscprog_WatchedDeathScreensInput.Name = "Miscprog_WatchedDeathScreensInput";
            this.Miscprog_WatchedDeathScreensInput.Size = new System.Drawing.Size(123, 19);
            this.Miscprog_WatchedDeathScreensInput.TabIndex = 7;
            this.Miscprog_WatchedDeathScreensInput.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_WatchedDeathScreensInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Miscprog_WatchedSleepScreensInput
            // 
            this.Miscprog_WatchedSleepScreensInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Miscprog_WatchedSleepScreensInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Miscprog_WatchedSleepScreensInput.Controller = null;
            this.Miscprog_WatchedSleepScreensInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Miscprog_WatchedSleepScreensInput.IntegerIndex = 1;
            this.Miscprog_WatchedSleepScreensInput.Location = new System.Drawing.Point(6, 68);
            this.Miscprog_WatchedSleepScreensInput.Multiline = true;
            this.Miscprog_WatchedSleepScreensInput.Name = "Miscprog_WatchedSleepScreensInput";
            this.Miscprog_WatchedSleepScreensInput.Size = new System.Drawing.Size(123, 19);
            this.Miscprog_WatchedSleepScreensInput.TabIndex = 5;
            this.Miscprog_WatchedSleepScreensInput.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_WatchedSleepScreensInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Miscprog_SelectedSlugcatInput
            // 
            this.Miscprog_SelectedSlugcatInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Miscprog_SelectedSlugcatInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Miscprog_SelectedSlugcatInput.Controller = null;
            this.Miscprog_SelectedSlugcatInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Miscprog_SelectedSlugcatInput.IntegerIndex = 0;
            this.Miscprog_SelectedSlugcatInput.Location = new System.Drawing.Point(98, 21);
            this.Miscprog_SelectedSlugcatInput.Multiline = true;
            this.Miscprog_SelectedSlugcatInput.Name = "Miscprog_SelectedSlugcatInput";
            this.Miscprog_SelectedSlugcatInput.Size = new System.Drawing.Size(89, 19);
            this.Miscprog_SelectedSlugcatInput.TabIndex = 3;
            this.Miscprog_SelectedSlugcatInput.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_SelectedSlugcatInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Miscprog_RedUnlocked
            // 
            this.Miscprog_RedUnlocked.AutoSize = true;
            this.Miscprog_RedUnlocked.Controller = null;
            this.Miscprog_RedUnlocked.IntegerIndex = 8;
            this.Miscprog_RedUnlocked.Location = new System.Drawing.Point(157, 220);
            this.Miscprog_RedUnlocked.Name = "Miscprog_RedUnlocked";
            this.Miscprog_RedUnlocked.Size = new System.Drawing.Size(115, 19);
            this.Miscprog_RedUnlocked.TabIndex = 2;
            this.Miscprog_RedUnlocked.TagQuery = "mpd@INTEGERS/#";
            this.Miscprog_RedUnlocked.Text = "Hunter unlocked";
            this.Miscprog_RedUnlocked.UseVisualStyleBackColor = true;
            // 
            // Miscprog_MenuRegionInput
            // 
            this.Miscprog_MenuRegionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Miscprog_MenuRegionInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Miscprog_MenuRegionInput.Controller = null;
            this.Miscprog_MenuRegionInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Miscprog_MenuRegionInput.Location = new System.Drawing.Point(6, 21);
            this.Miscprog_MenuRegionInput.Multiline = true;
            this.Miscprog_MenuRegionInput.Name = "Miscprog_MenuRegionInput";
            this.Miscprog_MenuRegionInput.Size = new System.Drawing.Size(89, 19);
            this.Miscprog_MenuRegionInput.TabIndex = 0;
            this.Miscprog_MenuRegionInput.TagQuery = "mpd@MENUREGION/#";
            this.Miscprog_MenuRegionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Menu
            // 
            this.Menu.AllowMerge = false;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Open,
            this.Menu_Save,
            this.Menu_SaveAs});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            // 
            // Menu_Open
            // 
            this.Menu_Open.Name = "Menu_Open";
            this.Menu_Open.Size = new System.Drawing.Size(48, 20);
            this.Menu_Open.Text = "Open";
            this.Menu_Open.Click += new System.EventHandler(this.Menu_Open_Click);
            // 
            // Menu_Save
            // 
            this.Menu_Save.Enabled = false;
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.Size = new System.Drawing.Size(43, 20);
            this.Menu_Save.Text = "Save";
            this.Menu_Save.Click += new System.EventHandler(this.Menu_Save_Click);
            // 
            // Menu_SaveAs
            // 
            this.Menu_SaveAs.Enabled = false;
            this.Menu_SaveAs.Name = "Menu_SaveAs";
            this.Menu_SaveAs.Size = new System.Drawing.Size(59, 20);
            this.Menu_SaveAs.Text = "Save As";
            this.Menu_SaveAs.Click += new System.EventHandler(this.Menu_SaveAs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplitH);
            this.Controls.Add(this.Menu);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "RainState";
            this.SplitH.Panel1.ResumeLayout(false);
            this.SplitH.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitH)).EndInit();
            this.SplitH.ResumeLayout(false);
            this.MainTagController.ResumeLayout(false);
            this.MiscprogGroup.ResumeLayout(false);
            this.TagMiscprogController.ResumeLayout(false);
            this.TagMiscprogController.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView StateTree;
        private System.Windows.Forms.SplitContainer SplitH;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_SaveAs;
        private TagWatchController MainTagController;
        private System.Windows.Forms.GroupBox MiscprogGroup;
        private TagWatchController TagMiscprogController;
        private TagTextBox Miscprog_MenuRegionInput;
        private IntegersArrayCheckBox Miscprog_RedUnlocked;
        private IntegersArrayTextBox Miscprog_SelectedSlugcatInput;
        private IntegersArrayTextBox Miscprog_WatchedSleepScreensInput;
        private IntegersArrayTextBox Miscprog_WatchedDeathScreensWithFlowerInput;
        private IntegersArrayTextBox Miscprog_WatchedDeathScreensInput;
        private IntegersArrayTextBox Miscprog_WatchedMalnourishScreensInput;
        private IntegersArrayTextBox Miscprog_MeatEatingTutorialsInput;
        private IntegersArrayTextBox Miscprog_KarmaLossWarningsKarmaLossWarningsInput;
        private IntegersArrayTextBox Miscprog_StarvationTutorialInput;
        private IntegersArrayCheckBox Miscprog_LookedForOlderVersionSaveFile;
        private IntegersArrayCheckBox Miscprog_RedVisitedPebbles;
    }
}