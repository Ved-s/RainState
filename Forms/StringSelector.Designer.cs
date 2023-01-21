namespace RainState.Forms
{
    partial class StringSelector
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
            this.ChoiceStack = new RainState.Controls.StackPanel();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChoiceStack
            // 
            this.ChoiceStack.AutoScroll = true;
            this.ChoiceStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoiceStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChoiceStack.Location = new System.Drawing.Point(5, 5);
            this.ChoiceStack.Name = "ChoiceStack";
            this.ChoiceStack.Padding = new System.Windows.Forms.Padding(20);
            this.ChoiceStack.Size = new System.Drawing.Size(334, 172);
            this.ChoiceStack.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(5, 177);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(334, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // StringSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(344, 205);
            this.Controls.Add(this.ChoiceStack);
            this.Controls.Add(this.Cancel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StringSelector";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "StringSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.StackPanel ChoiceStack;
        private System.Windows.Forms.Button Cancel;
    }
}