using RainState.Controls;
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

        public RecursiveTagWatchArrays? WatchArrays;

        public MainForm()
        {
            Instance = this;
            InitializeComponent();

            MainTagController.MainController = true;

            Menu.ForeColor = SystemColors.ControlLightLight;
            Menu.RenderMode = ToolStripRenderMode.Professional;
            Menu.Renderer = new ToolStripProfessionalRenderer(new DarkColorTable());
        }

        private void Menu_Open_Click(object sender, EventArgs e)
        {
            try
            {
                Text = "RainState: Opening file...";

                OpenFileDialog dialog = new();

                string newSaveLocation = Path.GetFullPath(Environment.ExpandEnvironmentVariables("%APPDATA%/../LocalLow/Videocult/Rain World"));
                if (Directory.Exists(newSaveLocation))
                    dialog.InitialDirectory = newSaveLocation;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                Text = "RainState: Reading file...";

                string savefile = File.ReadAllText(dialog.FileName);
                CurrentFile = StateFile.Load(savefile);

                if (CurrentFile is null)
                    return;

                CurrentFilePath = dialog.FileName;

                Text = "RainState: Building tag tree...";

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

                Text = "RainState: Searching for Rain World...";

                if (!RainWorldData.SearchRainWorld(dialog.FileName)
                 && MessageBox.Show(this, "Could not find RainWorld.exe.\nSelect Rain World path manually?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OpenFileDialog ofd = new();
                    ofd.Filter = "Executable|*.exe";
                    ofd.InitialDirectory = Path.GetDirectoryName(dialog.FileName);

                    if (ofd.ShowDialog() == DialogResult.OK)
                        RainWorldData.SetRainWorldPath(Path.GetDirectoryName(ofd.FileName));
                }

                Text = "RainState: Building UI...";

                InitializeUI();
            }
            finally
            {
                Text = "RainState";
            }
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

        void InitializeUI()
        {
            WatchArrays = new(0);
            MainTagController.BindArray(WatchArrays);
            BuildUI();
            TagWatchController.InitializeControllers(MainTagController);
            ITagControl.RefreshControls(CurrentFile?.MainTag, MainTagController);
        }

        void BuildUI()
        {
            List<(string, Control)> uiGroups = new()
            {
                ("Misc progression data",   new StateSections.MiscProg()),
                ("Unlocks",                 new StateSections.Unlocks()),
                ("Lore",                    new StateSections.Lore()),
                ("More Slugcats",           new StateSections.MoreSlugcats())
            };

            SectionsStack.Controls.Clear();

            foreach (var (name, control) in uiGroups)
            {
                CollapsedPanel panel = new();
                panel.Text = name;
                panel.Collapsed = true;
                panel.ContentHeight = control.Height;
                control.Dock = DockStyle.Fill;
                panel.Controls.Add(control);

                SectionsStack.Controls.Add(panel);
            }
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
