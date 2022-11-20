using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

        private string filePath = "@C:\\TestData.txt";
        private int correctlevels = 0;
        public int one, two, three, four = 0;

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
                if (node.Level == 0) one++;
                if (node.Level == 1) two++;
                if (node.Level == 2) three++;
                if (node.Level == 3) four++;
            }

            Console.WriteLine(one.ToString() + " " + two.ToString() + " " + three.ToString() + " " + four.ToString());
        }

        public static TreeNode<string, string> TestData()
        {
            /*string[] lineValues;
            using (StreamReader reader = new StreamReader(@"C:\\TestData.txt"))
            {
                lineValues = reader.ReadToEnd().Split(',');
            }

            TreeNode<string, string> root = new TreeNode<string, string>("root", null);
            {
                foreach(string values in lineValues)
                {
                    TreeNode<string, string> values = new TreeNode<string, string>(values, null);
                }
            }*/

            TreeNode<string,string> root = new TreeNode<string, string>("root", null);
            {
                TreeNode<string, string> node0 = root.AddChild("node0", null);
                TreeNode<string, string> node1 = root.AddChild("node1", null);
                {
                    TreeNode<string, string> node10 = node1.AddChild("node20", null);
                    TreeNode<string, string> node11 = node1.AddChild("node21", null);
                    {
                        TreeNode<string, string> node110 = node11.AddChild("node210", null);
                        TreeNode<string, string> node111 = node11.AddChild("node211", null);
                    }
                }
                TreeNode<string, string> node2 = root.AddChild("node2", null);
                {
                    TreeNode<string, string> node20 = node2.AddChild("node20", null);
                    TreeNode<string, string> node21 = node2.AddChild("node21", null);
                    {
                        TreeNode<string, string> node210 = node21.AddChild("node210", null);
                        TreeNode<string, string> node211 = node21.AddChild("node211", null);
                    }
                }
                TreeNode<string, string> node3 = root.AddChild("node3", null);
            }

            return root;
        }
    }
}
