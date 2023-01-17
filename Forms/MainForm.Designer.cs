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
            this.StateTree = new System.Windows.Forms.TreeView();
            this.SplitH = new System.Windows.Forms.SplitContainer();
            this.MainTagController = new RainState.TagControls.TagWatchController();
            this.SectionsStack = new RainState.Controls.StackPanel();
            this.MiscProgPanel = new RainState.Controls.CollapsedPanel();
            this.MiscProg = new RainState.StateSections.MiscProg();
            this.UnlocksPanel = new RainState.Controls.CollapsedPanel();
            this.unlocks1 = new RainState.StateSections.Unlocks();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SplitH)).BeginInit();
            this.SplitH.Panel1.SuspendLayout();
            this.SplitH.Panel2.SuspendLayout();
            this.SplitH.SuspendLayout();
            this.MainTagController.SuspendLayout();
            this.SectionsStack.SuspendLayout();
            this.MiscProgPanel.SuspendLayout();
            this.UnlocksPanel.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StateTree
            // 
            this.StateTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.StateTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateTree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StateTree.Location = new System.Drawing.Point(0, 0);
            this.StateTree.Name = "StateTree";
            this.StateTree.Size = new System.Drawing.Size(306, 715);
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
            this.SplitH.Size = new System.Drawing.Size(926, 715);
            this.SplitH.SplitterDistance = 306;
            this.SplitH.TabIndex = 1;
            // 
            // MainTagController
            // 
            this.MainTagController.Controller = null;
            this.MainTagController.Controls.Add(this.SectionsStack);
            this.MainTagController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTagController.Location = new System.Drawing.Point(0, 0);
            this.MainTagController.MainController = false;
            this.MainTagController.Name = "MainTagController";
            this.MainTagController.Size = new System.Drawing.Size(616, 715);
            this.MainTagController.TabIndex = 0;
            this.MainTagController.WatchQuery = "";
            // 
            // SectionsStack
            // 
            this.SectionsStack.AutoScroll = true;
            this.SectionsStack.Controls.Add(this.MiscProgPanel);
            this.SectionsStack.Controls.Add(this.UnlocksPanel);
            this.SectionsStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionsStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SectionsStack.Location = new System.Drawing.Point(0, 0);
            this.SectionsStack.Name = "SectionsStack";
            this.SectionsStack.Size = new System.Drawing.Size(616, 715);
            this.SectionsStack.TabIndex = 1;
            // 
            // MiscProgPanel
            // 
            this.MiscProgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MiscProgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiscProgPanel.Collapsed = true;
            this.MiscProgPanel.Controls.Add(this.MiscProg);
            this.MiscProgPanel.Location = new System.Drawing.Point(3, 3);
            this.MiscProgPanel.Name = "MiscProgPanel";
            this.MiscProgPanel.NormalHeight = 277;
            this.MiscProgPanel.Padding = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.MiscProgPanel.Size = new System.Drawing.Size(610, 24);
            this.MiscProgPanel.TabIndex = 0;
            this.MiscProgPanel.Text = "Misc progression data";
            // 
            // MiscProg
            // 
            this.MiscProg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MiscProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MiscProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiscProg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MiscProg.Location = new System.Drawing.Point(0, 22);
            this.MiscProg.Margin = new System.Windows.Forms.Padding(0);
            this.MiscProg.Name = "MiscProg";
            this.MiscProg.Size = new System.Drawing.Size(608, 0);
            this.MiscProg.TabIndex = 0;
            // 
            // UnlocksPanel
            // 
            this.UnlocksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.UnlocksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnlocksPanel.Collapsed = true;
            this.UnlocksPanel.Controls.Add(this.unlocks1);
            this.UnlocksPanel.Location = new System.Drawing.Point(3, 33);
            this.UnlocksPanel.Name = "UnlocksPanel";
            this.UnlocksPanel.NormalHeight = 387;
            this.UnlocksPanel.Padding = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.UnlocksPanel.Size = new System.Drawing.Size(610, 24);
            this.UnlocksPanel.TabIndex = 1;
            this.UnlocksPanel.Text = "Unlocks";
            // 
            // unlocks1
            // 
            this.unlocks1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.unlocks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unlocks1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.unlocks1.Location = new System.Drawing.Point(0, 22);
            this.unlocks1.Name = "unlocks1";
            this.unlocks1.Size = new System.Drawing.Size(608, 363);
            this.unlocks1.TabIndex = 2;
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
            this.Menu.Size = new System.Drawing.Size(926, 24);
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
            this.ClientSize = new System.Drawing.Size(926, 739);
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
            this.SectionsStack.ResumeLayout(false);
            this.MiscProgPanel.ResumeLayout(false);
            this.UnlocksPanel.ResumeLayout(false);
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
        private StateSections.MiscProg MiscProg;
        private Controls.StackPanel SectionsStack;
        private Controls.CollapsedPanel MiscProgPanel;
        private Controls.CollapsedPanel UnlocksPanel;
        private StateSections.Unlocks unlocks1;
    }
}