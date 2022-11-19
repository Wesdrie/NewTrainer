using System;
using System.Collections;
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
    public partial class WindowSort : Form
    {
        /// <summary>
        /// DATABASE CONNECTION
        /// </summary>
        //String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibraryDatabase.mdf;Integrated Security = True";
        //String insertCommand = "INSERT INTO SORT (SORT_ID, SORT_TIME, SORT_SCORE) VALUES (@A, @B, @C);";
        //String readCommand = "SELECT MIN(SORT_TIME) AS DISPLAYTIME FROM SORT;";
        //String idCommand = "SELECT MAX(SORT_ID) AS DATAID FROM SORT;";

        //SqlConnection sqlConnection = new SqlConnection();

        /// <summary>
        /// VARIBLES
        /// </summary>
        Tools wrench = new Tools();

        List<String> generatedDecimals = new List<String>();
        List<String> sortedDecimals = new List<String>();
        List<String> userDecimals = new List<String>();

        int timerTicker, userScore, dataId;

        public WindowSort()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ON LOAD BEGIN TIMER, GENERATE ITEMS AND FILL LISTS FOR CHECKS
        /// </summary>
        private void WindowSort_Load(object sender, EventArgs e)
        {
            try
            {
                //sqlConnection.ConnectionString = connectionString;
                //SqlCommand sqlCommand = new SqlCommand(readCommand, sqlConnection);
                //sqlConnection.Open();

                //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                //sqlDataReader.Read();
                //TextBeat.Text = sqlDataReader["DISPLAYTIME"].ToString() + " Seconds";

                //sqlConnection.Close();

                ListSort.Enabled = true;

                TimerSort.Start();

                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(10);

                    generatedDecimals.Add(wrench.GenerateDecimal());
                    sortedDecimals.Add(generatedDecimals[i]);
                    ListSort.Items.Add(generatedDecimals[i]);

                    System.Threading.Thread.Sleep(10);
                }

                sortedDecimals.Sort();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TimerSort_Tick(object sender, EventArgs e)
        {
            try
            {
                timerTicker++;
                TextTime.Text = timerTicker.ToString() + " Seconds";

                userDecimals.Clear();

                foreach(var item in ListSort.Items)
                {
                    userDecimals.Add(item.ToString());
                }

                userScore = wrench.CheckDecimal(sortedDecimals, userDecimals);
                TextScore.Text = userScore.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DRAG & DROP REORDER
        /// </summary>
        private void ListSort_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ListSort.DoDragDrop(ListSort.SelectedItem, DragDropEffects.Move);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ListSort_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Move;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ListSort_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Point point = ListSort.PointToClient(new Point(e.X, e.Y));
                int index = ListSort.IndexFromPoint(point);
                if (index < 0)
                {
                    index = ListSort.Items.Count - 1;
                }

                ListSort.Items.Remove(e.Data.GetData(DataFormats.Text));
                ListSort.Items.Insert(index, e.Data.GetData(DataFormats.Text));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// NAVIGATION BUTTONS & ENSURE APPLICAITON CLOSES
        /// </summary>
        private void ButtonComplete_Click(object sender, EventArgs e)
        {
            try
            {
                TimerSort.Stop();

                if (userScore == 10)
                {
                    //sqlConnection.ConnectionString = connectionString;
                    //SqlCommand getCommand = new SqlCommand(idCommand, sqlConnection);
                    //sqlConnection.Open();

                    //SqlDataReader sqlDataReader = getCommand.ExecuteReader();

                    //sqlDataReader.Read();
                    //dataId = Int32.Parse(sqlDataReader["DATAID"].ToString());

                    //sqlConnection.Close();

                    //sqlConnection.ConnectionString = connectionString;
                    //SqlCommand sqlCommand = new SqlCommand(insertCommand, sqlConnection);
                    //sqlConnection.Open();

                    //sqlCommand.Parameters.AddWithValue("@A", dataId + 1);
                    //sqlCommand.Parameters.AddWithValue("@B", timerTicker);
                    //sqlCommand.Parameters.AddWithValue("@C", userScore);

                    //int row = sqlCommand.ExecuteNonQuery();

                    //sqlConnection.Close();

                    //if (row != 0)
                    //{
                    //    MessageBox.Show("Game Infromation Was Recorded!", "Note", MessageBoxButtons.OK);
                    //    ListSort.Enabled = false;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Game Infromation Was NOT Recorded!", "Note", MessageBoxButtons.OK);
                    //}
                }
                else
                {
                    MessageBox.Show("You NEED A Score Of 10 Points To Submit!", "Note", MessageBoxButtons.OK);
                    ButtonReset_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                /// MAYBE BEST TO MOVE FUNCTION TO TOOLS
                /// </summary>
                TimerSort.Stop();
                timerTicker = 0;
                TextTime.Text = "0 Seconds";

                ListSort.Items.Clear();

                for (int i = 0; i < 10; i++)
                {
                    ListSort.Items.Add(generatedDecimals[i]);
                }

                //sqlConnection.ConnectionString = connectionString;
                //SqlCommand sqlCommand = new SqlCommand(readCommand, sqlConnection);
                //sqlConnection.Open();

                //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                //sqlDataReader.Read();
                //TextBeat.Text = sqlDataReader["DISPLAYTIME"].ToString() + " Seconds";

                //sqlConnection.Close();

                ListSort.Enabled = true;

                TimerSort.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            WindowMain windowMain = new WindowMain();
            windowMain.Show();

            this.Hide();
        }

        private void WindowSort_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
