using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainState.Forms
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; private set; } = null!;

        public MainForm()
        {
            Instance = this;
            InitializeComponent();
        }
    }
}
