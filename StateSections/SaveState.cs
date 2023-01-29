using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainState.StateSections
{
    public class SaveState : UserControl
    {
#nullable disable
        private TagControls.TagWatchController Controller;
        private Label SeedLabel;
        private TagControls.TagTextBox Seed;
        private TagControls.TagTextBox Food;
        private Label FoodLabel;
        private TagControls.TagTextBox CycleNum;
        private Label CycleNumLabel;
        private TagControls.TagTextBox DenPos;
        private Label DenPosLabel;
        public string SaveStateNumber;
#nullable restore

        public SaveState(string number)
        {
            SaveStateNumber = number;
            InitializeComponent();

            Controller.WatchQuery = $"progDiv@SAVE STATE[sv$/@SAV STATE NUMBER/#{number}]/sv$";
        }

        private void InitializeComponent()
        {
            this.Controller = new RainState.TagControls.TagWatchController();
            this.Food = new RainState.TagControls.TagTextBox();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.CycleNum = new RainState.TagControls.TagTextBox();
            this.CycleNumLabel = new System.Windows.Forms.Label();
            this.DenPos = new RainState.TagControls.TagTextBox();
            this.DenPosLabel = new System.Windows.Forms.Label();
            this.Seed = new RainState.TagControls.TagTextBox();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.Controller.SuspendLayout();
            this.SuspendLayout();
            // 
            // Controller
            // 
            this.Controller.Controller = null;
            this.Controller.Controls.Add(this.Food);
            this.Controller.Controls.Add(this.FoodLabel);
            this.Controller.Controls.Add(this.CycleNum);
            this.Controller.Controls.Add(this.CycleNumLabel);
            this.Controller.Controls.Add(this.DenPos);
            this.Controller.Controls.Add(this.DenPosLabel);
            this.Controller.Controls.Add(this.Seed);
            this.Controller.Controls.Add(this.SeedLabel);
            this.Controller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controller.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controller.Location = new System.Drawing.Point(0, 0);
            this.Controller.MainController = false;
            this.Controller.Name = "Controller";
            this.Controller.Size = new System.Drawing.Size(377, 93);
            this.Controller.TabIndex = 0;
            this.Controller.WatchQuery = "";
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Food.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Food.Controller = null;
            this.Food.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Food.Location = new System.Drawing.Point(101, 62);
            this.Food.Multiline = true;
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(89, 19);
            this.Food.TabIndex = 7;
            this.Food.TagQuery = "sv@FOOD/#";
            this.Food.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FoodLabel
            // 
            this.FoodLabel.AutoSize = true;
            this.FoodLabel.Location = new System.Drawing.Point(98, 44);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(34, 15);
            this.FoodLabel.TabIndex = 6;
            this.FoodLabel.Text = "Food";
            // 
            // CycleNum
            // 
            this.CycleNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CycleNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CycleNum.Controller = null;
            this.CycleNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CycleNum.Location = new System.Drawing.Point(6, 62);
            this.CycleNum.Multiline = true;
            this.CycleNum.Name = "CycleNum";
            this.CycleNum.Size = new System.Drawing.Size(89, 19);
            this.CycleNum.TabIndex = 5;
            this.CycleNum.TagQuery = "sv@CYCLENUM/#";
            this.CycleNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CycleNumLabel
            // 
            this.CycleNumLabel.AutoSize = true;
            this.CycleNumLabel.Location = new System.Drawing.Point(3, 44);
            this.CycleNumLabel.Name = "CycleNumLabel";
            this.CycleNumLabel.Size = new System.Drawing.Size(36, 15);
            this.CycleNumLabel.TabIndex = 4;
            this.CycleNumLabel.Text = "Cycle";
            // 
            // DenPos
            // 
            this.DenPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DenPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DenPos.Controller = null;
            this.DenPos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DenPos.Location = new System.Drawing.Point(101, 21);
            this.DenPos.Multiline = true;
            this.DenPos.Name = "DenPos";
            this.DenPos.Size = new System.Drawing.Size(89, 19);
            this.DenPos.TabIndex = 3;
            this.DenPos.TagQuery = "sv@DENPOS/#";
            this.DenPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DenPosLabel
            // 
            this.DenPosLabel.AutoSize = true;
            this.DenPosLabel.Location = new System.Drawing.Point(98, 3);
            this.DenPosLabel.Name = "DenPosLabel";
            this.DenPosLabel.Size = new System.Drawing.Size(60, 15);
            this.DenPosLabel.TabIndex = 2;
            this.DenPosLabel.Text = "Den room";
            // 
            // Seed
            // 
            this.Seed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Seed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Seed.Controller = null;
            this.Seed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Seed.Location = new System.Drawing.Point(6, 21);
            this.Seed.Multiline = true;
            this.Seed.Name = "Seed";
            this.Seed.Size = new System.Drawing.Size(89, 19);
            this.Seed.TabIndex = 1;
            this.Seed.TagQuery = "sv@SEED/#";
            this.Seed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Location = new System.Drawing.Point(3, 3);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(32, 15);
            this.SeedLabel.TabIndex = 0;
            this.SeedLabel.Text = "Seed";
            // 
            // SaveState
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.Controller);
            this.Name = "SaveState";
            this.Size = new System.Drawing.Size(377, 93);
            this.Controller.ResumeLayout(false);
            this.Controller.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
