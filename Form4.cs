using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                Console.WriteLine(indent + (node.kData ?? "null"));
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
            int counter = 0;

            TreeNode<string, string> root = new TreeNode<string, string>("root", null);
            {
                foreach (string line in System.IO.File.ReadLines(@"C:\Users\Hendr\Documents\TestData.txt"))
                {
                    string[] lineValues = line.Split(',');

                    foreach(string value in lineValues)
                    {
                        System.Console.WriteLine(value);
                    }
                }
            }

            return root;
        }
    }
}
