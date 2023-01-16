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
            this.StateTree = new System.Windows.Forms.TreeView();
            this.SplitH = new System.Windows.Forms.SplitContainer();
            this.MainTagController = new RainState.TagControls.TagWatchController();
            this.MiscprogGroup = new System.Windows.Forms.GroupBox();
            this.TagMiscprogController = new RainState.TagControls.TagWatchController();
            this.Miscprog_RedUnlocked = new RainState.TagControls.IntegersArrayCheckBox();
            this.Miscprog_MenuRegionInput = new RainState.TagControls.TagTextBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            Miscprog_MenuRegionLabel = new System.Windows.Forms.Label();
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
            this.MiscprogGroup.Size = new System.Drawing.Size(530, 204);
            this.MiscprogGroup.TabIndex = 0;
            this.MiscprogGroup.TabStop = false;
            this.MiscprogGroup.Text = "Misc progression data";
            // 
            // TagMiscprogController
            // 
            this.TagMiscprogController.Controller = null;
            this.TagMiscprogController.Controls.Add(this.Miscprog_RedUnlocked);
            this.TagMiscprogController.Controls.Add(this.Miscprog_MenuRegionInput);
            this.TagMiscprogController.Controls.Add(Miscprog_MenuRegionLabel);
            this.TagMiscprogController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TagMiscprogController.Location = new System.Drawing.Point(3, 19);
            this.TagMiscprogController.MainController = false;
            this.TagMiscprogController.Name = "TagMiscprogController";
            this.TagMiscprogController.Size = new System.Drawing.Size(524, 182);
            this.TagMiscprogController.TabIndex = 0;
            this.TagMiscprogController.WatchQuery = "progDiv@MISCPROG/mpd$";
            // 
            // Miscprog_RedUnlocked
            // 
            this.Miscprog_RedUnlocked.AutoSize = true;
            this.Miscprog_RedUnlocked.Controller = null;
            this.Miscprog_RedUnlocked.IntegerIndex = 8;
            this.Miscprog_RedUnlocked.Location = new System.Drawing.Point(3, 50);
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
            this.Miscprog_MenuRegionInput.Location = new System.Drawing.Point(3, 21);
            this.Miscprog_MenuRegionInput.Name = "Miscprog_MenuRegionInput";
            this.Miscprog_MenuRegionInput.Size = new System.Drawing.Size(100, 23);
            this.Miscprog_MenuRegionInput.TabIndex = 0;
            this.Miscprog_MenuRegionInput.TagQuery = "mpd@MENUREGION/#";
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
    }
}