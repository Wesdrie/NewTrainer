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
        /// VARIBLES
        /// </summary>
        Tools wrench = new Tools();

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
    }

    
}
