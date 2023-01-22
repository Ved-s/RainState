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
            //string p = "ts@TEST[ts$/@SUB1/#15,ts$/@SUB2/#15]";
            //foreach (var qp in new TagQueryPathEnumerator(p))
            //{
            //    Console.WriteLine(qp);
            //}

            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
