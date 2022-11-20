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
using System.Xml.Linq;

namespace LibraryTrainer
{
    public partial class WindowCall : Form
    {
        Tools tools = new Tools();

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
        
        private void WindowCall_Load(object sender, EventArgs e)
        {
            foreach (string line in File.ReadAllLines(@"C:\TestData.txt"))
            {
                string[] values = line.Split(',');

                for(int i = 0; i < 1; i++)
                {
                    Console.WriteLine(values[i]);
                    Console.WriteLine(values[i + 1]);
                }
                Console.WriteLine("- - - - - - - - - - - - -");
            }
        }
    }
}
