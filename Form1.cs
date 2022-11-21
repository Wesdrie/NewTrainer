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
        public WindowMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// NAVIGATE TO SORTING GAME
        /// </summary>
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            try
            {
                WindowSort windowSort = new WindowSort();
                windowSort.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// NAVIGATE TO AREA GAME
        /// </summary>
        private void ButtonArea_Click(object sender, EventArgs e)
        {
            try
            {
                WindowAreas windowAreas = new WindowAreas();
                windowAreas.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// NAVIGATE TO CALL GAME
        /// </summary>
        private void ButtonCall_Click(object sender, EventArgs e)
        {
            try
            {
                WindowCall windowCall = new WindowCall();
                windowCall.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ON-BUTTON EXIT APPLICATION & ENSURE APPLICATION CLOSES
        /// </summary>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ON-BUTTON 'X' EXIT APPLICATION & ENSURE APPLICATION CLOSES
        /// </summary>
        private void WindowMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
