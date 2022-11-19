using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTrainer
{
    public partial class WindowMain : Form
    {
        /// <summary>
        /// DATABASE CONNECTION
        /// </summary>
        
        public WindowMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ON-WINDOW-LOADS, DO THESE:
        /// ENSURE LOCAL DB IS CREATED.
        /// </summary>
        private void WindowMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// NAVIGATION BUTTONS & ENSURE APPLICAITON CLOSES
        /// </summary>
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            WindowSort windowSort = new WindowSort();
            windowSort.Show();

            this.Hide();
        }

        private void ButtonArea_Click(object sender, EventArgs e)
        {
            WindowAreas windowAreas = new WindowAreas();
            windowAreas.Show();

            this.Hide();
        }

        private void ButtonCall_Click(object sender, EventArgs e)
        {
            WindowCall windowCall = new WindowCall();
            windowCall.Show();

            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WindowMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
