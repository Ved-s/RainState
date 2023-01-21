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
    public partial class StringSelector : Form
    {
        string? SelectedChoice;
        static StringSelector? Instance;

        public StringSelector()
        {
            InitializeComponent();
        }

        public static string? ShowDialog(string title, IEnumerable<string> choices, Func<string, string>? choiceDisplayNames = null)
        {
            Instance ??= new();

            Instance.ChoiceStack.Controls.Clear();
            Instance.Text = title;

            foreach (string choice in choices) 
            {
                Button button = new()
                {
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderColor = Color.FromArgb(100, 100, 100) },
                    Text = choiceDisplayNames?.Invoke(choice) ?? choice,
                    DialogResult = DialogResult.OK,
                };
                button.Click += (_, _) => Instance.SelectedChoice = choice;
                Instance.ChoiceStack.Controls.Add(button);
            }

            if (Instance.ShowDialog() == DialogResult.Cancel)
                return null;
            return Instance.SelectedChoice;
        }
    }
}
