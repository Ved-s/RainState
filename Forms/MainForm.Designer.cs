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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ManualQuery = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SplitH)).BeginInit();
            this.SplitH.Panel1.SuspendLayout();
            this.SplitH.Panel2.SuspendLayout();
            this.SplitH.SuspendLayout();
            this.MainTagController.SuspendLayout();
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
            this.StateTree.Size = new System.Drawing.Size(252, 397);
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
            this.SplitH.Size = new System.Drawing.Size(769, 397);
            this.SplitH.SplitterDistance = 252;
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
            this.MainTagController.Size = new System.Drawing.Size(513, 397);
            this.MainTagController.TabIndex = 0;
            this.MainTagController.WatchQuery = "";
            // 
            // SectionsStack
            // 
            this.SectionsStack.AutoScroll = true;
            this.SectionsStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionsStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SectionsStack.Location = new System.Drawing.Point(0, 0);
            this.SectionsStack.Name = "SectionsStack";
            this.SectionsStack.Size = new System.Drawing.Size(513, 397);
            this.SectionsStack.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.AllowMerge = false;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Open,
            this.Menu_Save,
            this.Menu_SaveAs,
            this.Menu_ManualQuery});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(769, 24);
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
            // Menu_ManualQuery
            // 
            this.Menu_ManualQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Menu_ManualQuery.Name = "Menu_ManualQuery";
            this.Menu_ManualQuery.Size = new System.Drawing.Size(94, 20);
            this.Menu_ManualQuery.Text = "Manual Query";
            this.Menu_ManualQuery.Click += new System.EventHandler(this.Menu_ManualQuery_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(769, 421);
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
        private Controls.StackPanel SectionsStack;
        private System.Windows.Forms.ToolStripMenuItem Menu_ManualQuery;
    }
}