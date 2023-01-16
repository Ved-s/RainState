﻿namespace RainState.Forms
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
            this.MainTagController = new RainState.TagWatchController();
            this.tagWatchController1 = new RainState.TagWatchController();
            this.tagTextBox1 = new RainState.TagTextBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SplitH)).BeginInit();
            this.SplitH.Panel1.SuspendLayout();
            this.SplitH.Panel2.SuspendLayout();
            this.SplitH.SuspendLayout();
            this.MainTagController.SuspendLayout();
            this.tagWatchController1.SuspendLayout();
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
            this.MainTagController.Controls.Add(this.tagWatchController1);
            this.MainTagController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTagController.Location = new System.Drawing.Point(0, 0);
            this.MainTagController.MainController = false;
            this.MainTagController.Name = "MainTagController";
            this.MainTagController.Size = new System.Drawing.Size(530, 426);
            this.MainTagController.TabIndex = 0;
            this.MainTagController.WatchQuery = "";
            // 
            // tagWatchController1
            // 
            this.tagWatchController1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tagWatchController1.Controller = null;
            this.tagWatchController1.Controls.Add(this.tagTextBox1);
            this.tagWatchController1.Location = new System.Drawing.Point(67, 116);
            this.tagWatchController1.MainController = false;
            this.tagWatchController1.Name = "tagWatchController1";
            this.tagWatchController1.Size = new System.Drawing.Size(200, 100);
            this.tagWatchController1.TabIndex = 1;
            this.tagWatchController1.WatchQuery = "progDiv@MISCPROG/mpd$";
            // 
            // tagTextBox1
            // 
            this.tagTextBox1.Controller = null;
            this.tagTextBox1.Location = new System.Drawing.Point(72, 38);
            this.tagTextBox1.Name = "tagTextBox1";
            this.tagTextBox1.Size = new System.Drawing.Size(100, 23);
            this.tagTextBox1.TabIndex = 0;
            this.tagTextBox1.TagQuery = "mpd@TEST/#";
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
            this.tagWatchController1.ResumeLayout(false);
            this.tagWatchController1.PerformLayout();
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
        private TagTextBox tagTextBox1;
        private TagWatchController tagWatchController1;
    }
}