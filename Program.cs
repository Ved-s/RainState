using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;

namespace RainState
{
    public static class Program
    {

        [STAThread]
        public static void Main()
        {
            string savefile = File.ReadAllText("../../../sav_2.txt");

            StateFile file = StateFile.Load(savefile) ?? throw new NotImplementedException();

            Application app = new();
            MainWindow main = new();

            FrameworkElement element = file.MainTag.CreateTreeNode();

            if (element is TreeViewItem item)
                foreach (object child in item.Items.Cast<object>().ToArray())
                {
                    item.Items.Remove(child);
                    main.TagTree.Items.Add(child);
                }
            else
                main.TagTree.Items.Add(element);

            app.Run(main);

            using (FileStream fs = File.Create("../../../sav_3.txt"))
                file.Save(fs);
        }

        
    }
}
