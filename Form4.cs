using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTrainer
{
    public partial class WindowCall : Form
    {
        /// <summary>
        /// DECLARE VARIBLES
        /// </summary>

        Tools tools = new Tools();

        TreeNode<string, string> node;

        public WindowCall()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            WindowMain windowMain = new WindowMain();
            windowMain.Show();

            this.Hide();
        }

        private void WindowCall_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// ON WINDOW LOAD PREFORM FUNCTIONS
        /// </summary>
        
        private void WindowCall_Load(object sender, EventArgs e)
        {
            TreeNode<string, string> treeRoot = TestData();
            foreach (TreeNode<string, string> node in treeRoot)
            {
                string indent = CreateIndent(node.Level);
                Console.WriteLine(indent + (node.vData ?? "null"));
            }
        }

        private static String CreateIndent(int depth)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < depth; i++)
            {
                sb.Append(' ');
            }
            return sb.ToString();
        }

        public static TreeNode<string, string> TestData()
        {
            TreeNode<string, string> root = new TreeNode<string, string>("root", null);
            {
                TreeNode<string, string> node0 = root.AddChild("000", "General Information");
                TreeNode<string, string> node1 = root.AddChild("100", "Philosphy");
                TreeNode<string, string> node2 = root.AddChild("200", "Religion");
                {
                    TreeNode<string, string> node20 = node2.AddChild("210", "Theory of Religion");
                    TreeNode<string, string> node21 = node2.AddChild("230", "Chrsitianity");
                    {
                        TreeNode<string, string> node210 = node21.AddChild("233", "Humnakind");
                        TreeNode<string, string> node211 = node21.AddChild("236", "Eschatology");
                    }
                }
                TreeNode<string, string> node3 = root.AddChild("300", "Scoial Sciences");
                {
                    TreeNode<string, string> node30 = node3.AddChild("320", "Political Sciences");
                }
            }

            return root;
        }
    }
}
