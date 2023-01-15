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
    public partial class StringEditDialogue : Form
    {
        static StringEditDialogue? Instance;

        public string Value 
        {
            get => TextValue.Text; 
            set => TextValue.Text = value;
        }

        public StringEditDialogue()
        {
            InitializeComponent();
        }

        public static void ShowDialog(string value, Action<string> onSuccess)
        {
            if (ShowDialog(value, out string result) == DialogResult.OK)
                onSuccess(result);
        }

        public static DialogResult ShowDialog(string value, out string result)
        {
            Instance ??= new();
            Instance.Value = value;
            DialogResult dr = Instance.ShowDialog();
            result = Instance.Value;
            return dr;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Hide();
            base.OnClosing(e);
        }
    }
}
