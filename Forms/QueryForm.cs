using RainState.Tags;
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
    public partial class QueryForm : Form
    {
        public static QueryForm? Instance;

        public QueryForm()
        {
            InitializeComponent();
        }

        public new static void Show()
        {
            Instance ??= new();
            Instance.Visible = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }

        private void ExecuteQuery_Click(object sender, EventArgs e)
        {
            Tag? result = MainForm.Instance.CurrentFile?.MainTag.QueryTag(Query.Text, !ReadOnlyQuery.Checked);

            ResultLabel.Text = $"Result ({result?.GetType().Name ?? "null"})";

            ResultTree.Nodes.Clear();
            if (result is not null)
            {
                TreeNode node = result.CreateTreeNode(true);
                if (node.Text == "")
                    node.Text = "Result";

                ResultTree.Nodes.Add(node);
                node.Expand();
            }
        }

        private void Query_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                ExecuteQuery_Click(null!, null!);
            }
        }
    }
}
