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

        Dictionary<string, string> NewSaveFileTagDisplayNames = new()
        {
            ["save"] = "Save file",
            ["save__Backup"] = "Save file backup",
            ["options"] = "Game options",
            ["ArenaSetup"] = "Arena setup",
            ["core"] = "Expeditions data",
        };

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
                CurrentFile = StateFile.Load(savefile, names => 
                {
                    if (!names.Any())
                    {
                        MessageBox.Show("File is empty.\nRainState currently does not support file creation.\nTry opening another file with some progress.", "Error", MessageBoxButtons.OK);
                        return null;
                    }

                    if (names.Count() <= 1)
                        return names.First();
                    return StringSelector.ShowDialog("Select save file to load", names, name => 
                    {
                        if (NewSaveFileTagDisplayNames.TryGetValue(name, out string? displayName))
                            return displayName;
                        return name;
                    });
                });

                if (CurrentFile is null)
                    return;

                CurrentFilePath = dialog.FileName;

                Text = "RainState: Building tag tree...";

                TreeNode node = CurrentFile.MainTag.CreateTreeNode(false);

                if (node.Text == "")
                    node.Text = CurrentFile.NewFormatTag?.Key ?? Path.GetFileName(CurrentFilePath);

                StateTree.Nodes.Clear();
                StateTree.Nodes.Add(node);
                node.Expand();

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

                InitializeUI();
            }
            finally
            {
                if (CurrentFile?.NewFormatTag is not null)
                {
                    string displayname =
                        NewSaveFileTagDisplayNames.TryGetValue(CurrentFile.NewFormatTag.Key, out string? val) ? val
                        : CurrentFile.NewFormatTag.Key;
                    Text = $"RainState: Editing {displayname}";
                }
                else
                {
                    Text = "RainState";
                }
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
        private void Menu_ManualQuery_Click(object sender, EventArgs e)
        {
            QueryForm.Show();
        }

        internal void TagChanged(Tag tag)
        {
            WatchArrays?.TagChanged(tag);
        }

        void InitializeUI()
        {
            Text = "RainState: Building UI...";
            WatchArrays = new(0);
            MainTagController.BindArray(WatchArrays);
            BuildUI();
            Text = "RainState: Binding UI...";
            TagWatchController.InitializeControllers(MainTagController);
            Text = "RainState: Refreshing UI...";
            ITagControl.RefreshControls(CurrentFile?.MainTag, MainTagController);
        }
        void BuildUI()
        {
            if (CurrentFile is null)
                return;

            List<(string, Control)> uiGroups = new();

            StateSwitch.ClearTabs();

            if (CurrentFile?.NewFormatTag is null || CurrentFile.NewFormatTag.Key == "save" || CurrentFile.NewFormatTag.Key == "save__Backup")
            {
                uiGroups.Add(("Misc progression data", new StateSections.MiscProg()));
                uiGroups.Add(("Unlocks", new StateSections.Unlocks()));
                uiGroups.Add(("Lore", new StateSections.Lore()));
                uiGroups.Add(("More Slugcats", new StateSections.MoreSlugcats()));

                if (RainWorldData.PlayableSlugcats is not null)
                    foreach (string slugcat in RainWorldData.PlayableSlugcats)
                        uiGroups.Add(($"{slugcat} playthrough", new StateSections.SaveState(slugcat))); 
            }

            if (uiGroups.Count == 0)
            {
                StateSwitch.Visible = false;
                NoStatesLabel.Visible = true;
            }
            else
            {
                StateSwitch.Visible = true;
                NoStatesLabel.Visible = false;
                foreach (var (name, control) in uiGroups)
                {
                    StateSwitch.AddTab(name, control);
                }
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
