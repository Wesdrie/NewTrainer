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
        DictionaryTree<string, string> tree = new DictionaryTree<string, string>();

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
            var root = new DictionaryTree<string, string>
            {
                Parent = "Dewey" + "Tree";
            };
        }
    }

    
}
