using RainState.TagControls;
using RainState.Tags;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainState.Forms
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; private set; } = null!;
        public StateFile? CurrentFile { get; private set; }
        public string? CurrentFilePath { get; private set; }

        public RecursiveTagWatchArrays WatchArrays = new(0);

        public MainForm()
        {
            Instance = this;
            InitializeComponent();

            MainTagController.MainController = true;
            MainTagController.BindArray(WatchArrays);
            TagWatchController.InitializeControllers(MainTagController);
            ITagControl.RefreshControls(null, MainTagController);

            Menu.ForeColor = SystemColors.ControlLightLight;
            Menu.RenderMode = ToolStripRenderMode.Professional;
            Menu.Renderer = new ToolStripProfessionalRenderer(new DarkColorTable());
        }

        private void Menu_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            string savefile = File.ReadAllText(dialog.FileName);
            CurrentFile = StateFile.Load(savefile) ?? throw new FileLoadException();
            CurrentFilePath = dialog.FileName;

            TreeNode node = CurrentFile.MainTag.CreateTreeNode();

            StateTree.Nodes.Clear();
            if (node.Nodes.Count > 0)
                foreach (TreeNode child in node.Nodes.Cast<TreeNode>().ToArray())
                {
                    node.Nodes.Remove(child);
                    StateTree.Nodes.Add(child);
                }
            else
                StateTree.Nodes.Add(node);

            Menu_Save.Enabled = true;
            Menu_SaveAs.Enabled = true;

            ITagControl.RefreshControls(CurrentFile.MainTag, MainTagController);
        }
        private void Menu_Save_Click(object sender, EventArgs e)
        {
            if (CurrentFile is null || CurrentFilePath is null)
                return;

            using FileStream fs = File.Create(CurrentFilePath);
            CurrentFile.Save(fs);
        }
        private void Menu_SaveAs_Click(object sender, EventArgs e)
        {
            if (CurrentFile is null)
                return;

            SaveFileDialog dialog = new();

            if (CurrentFilePath is not null)
            {
                dialog.InitialDirectory = Path.GetDirectoryName(CurrentFilePath);
                dialog.FileName = Path.GetFileName(CurrentFilePath);
            }
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            CurrentFilePath = dialog.FileName;
            using FileStream fs = File.Create(dialog.FileName);
            CurrentFile.Save(fs);
        }

        internal void TagChanged(Tag tag)
        {
            WatchArrays.TagChanged(tag);
        }

        class DarkColorTable : ProfessionalColorTable
        {
            public override Color MenuStripGradientBegin => Color.FromArgb(40, 40, 40);
            public override Color MenuStripGradientEnd   => Color.FromArgb(40, 40, 40);

            public override Color MenuItemBorder => Color.FromArgb(100, 100, 100);

            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(64, 64, 64);
            public override Color MenuItemSelectedGradientEnd   => Color.FromArgb(64, 64, 64);
        }
    }
}
