using RainState.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RainState
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();

            string savefile = File.ReadAllText("../../../sav_3.txt");
            StateFile file = StateFile.Load(savefile) ?? throw new NotImplementedException();

            MainForm main = new();

            TreeNode node = file.MainTag.CreateTreeNode();

            if (node.Nodes.Count > 0)
                foreach (TreeNode child in node.Nodes.Cast<TreeNode>().ToArray())
                {
                    node.Nodes.Remove(child);
                    main.StateTree.Nodes.Add(child);
                }
            else
                main.StateTree.Nodes.Add(node);

            Application.Run(main);

            using (FileStream fs = File.Create("../../../sav.txt"))
                file.Save(fs);
        }

        
    }
}
