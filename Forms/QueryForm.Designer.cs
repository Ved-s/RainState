namespace RainState.Forms
{
    partial class QueryForm
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
            this.Query = new System.Windows.Forms.TextBox();
            this.QueryLabel = new System.Windows.Forms.Label();
            this.ExecuteQuery = new System.Windows.Forms.Button();
            this.ReadOnlyQuery = new System.Windows.Forms.CheckBox();
            this.ResultTree = new System.Windows.Forms.TreeView();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Query
            // 
            this.Query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Query.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Query.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Query.Location = new System.Drawing.Point(12, 39);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(361, 23);
            this.Query.TabIndex = 0;
            this.Query.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Query_KeyDown);
            // 
            // QueryLabel
            // 
            this.QueryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryLabel.Location = new System.Drawing.Point(12, 17);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(330, 19);
            this.QueryLabel.TabIndex = 1;
            this.QueryLabel.Text = "Query";
            this.QueryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExecuteQuery
            // 
            this.ExecuteQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ExecuteQuery.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.ExecuteQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteQuery.Location = new System.Drawing.Point(379, 39);
            this.ExecuteQuery.Name = "ExecuteQuery";
            this.ExecuteQuery.Size = new System.Drawing.Size(71, 23);
            this.ExecuteQuery.TabIndex = 2;
            this.ExecuteQuery.Text = "Execute";
            this.ExecuteQuery.UseVisualStyleBackColor = false;
            this.ExecuteQuery.Click += new System.EventHandler(this.ExecuteQuery_Click);
            // 
            // ReadOnlyQuery
            // 
            this.ReadOnlyQuery.AutoSize = true;
            this.ReadOnlyQuery.Checked = true;
            this.ReadOnlyQuery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReadOnlyQuery.Location = new System.Drawing.Point(12, 68);
            this.ReadOnlyQuery.Name = "ReadOnlyQuery";
            this.ReadOnlyQuery.Size = new System.Drawing.Size(80, 19);
            this.ReadOnlyQuery.TabIndex = 3;
            this.ReadOnlyQuery.Text = "Read Only";
            this.ReadOnlyQuery.UseVisualStyleBackColor = true;
            // 
            // ResultTree
            // 
            this.ResultTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ResultTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultTree.Location = new System.Drawing.Point(12, 112);
            this.ResultTree.Name = "ResultTree";
            this.ResultTree.Size = new System.Drawing.Size(438, 103);
            this.ResultTree.TabIndex = 4;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.Location = new System.Drawing.Point(12, 90);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(438, 19);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(462, 227);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTree);
            this.Controls.Add(this.ReadOnlyQuery);
            this.Controls.Add(this.ExecuteQuery);
            this.Controls.Add(this.QueryLabel);
            this.Controls.Add(this.Query);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Query;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.Button ExecuteQuery;
        private System.Windows.Forms.CheckBox ReadOnlyQuery;
        private System.Windows.Forms.TreeView ResultTree;
        private System.Windows.Forms.Label ResultLabel;
    }
}