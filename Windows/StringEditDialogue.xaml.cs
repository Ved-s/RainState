using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RainState
{
    /// <summary>
    /// Interaction logic for StringEditDialogue.xaml
    /// </summary>
    public partial class StringEditDialogue : Window
    {
        static StringEditDialogue? Instance;

        private Action<string>? Callback;

        public StringEditDialogue()
        {
            InitializeComponent();
        }

        public static void Show(string value, Action<string> callback)
        {
            Instance ??= new();
            Instance.Callback = callback;
            Instance.StringValue.Text = value;
            Instance.ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
            Callback = null;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Callback?.Invoke(StringValue.Text);
            Callback = null;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Callback = null;
        }
    }
}
