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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace LibraryTrainer
{
    public partial class WindowAreas : Form
    {
        /// <summary>
        /// DECLARE VARIBLES:
        /// CONNETION STRING TO DATABASE & QUERIES.
        /// CALL TO OTHER CLASSES.
        /// DECLARE OBJECT, DICTIONAREIS & ASSOICATED DATA. NEED TO MOVE DATA DB.
        /// DECLARE LISTS & REMAINING VARIABLES.
        /// </summary>
        //String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibraryDatabase.mdf;Integrated Security = True";
        //String insertCommand = "INSERT INTO AREA (AREA_ID, AREA_TIME, AREA_SCORE) VALUES (@A, @B, @C);";
        //String readCommand = "SELECT MIN(AREA_TIME) AS DISPLAYTIME FROM AREA;";
        //String idCommand = "SELECT MAX(AREA_ID) AS DATAID FROM AREA;";

        //SqlConnection sqlConnection = new SqlConnection();

        Tools wrench = new Tools();
        Random random = new Random();

        CallAreas[] callAreas =
        {
            new CallAreas("000 - 099", "General Works", "Basic Information, Encyclopedias & Record Books"),
            new CallAreas("100 - 199", "Philosophy & Psychology", "Paranormal Phenomena, Ethics & “Who Am I”"),
            new CallAreas("200 - 299", "Religion", "Christians, Hindus & Mythology"),
            new CallAreas("300 - 399", "Social Sciences", "Laws, Cultures & Folklore"),
            new CallAreas("400 - 499", "Languages", "Dictionaries, Speech & Sign Language"),
            new CallAreas("500 - 599", "Science", "Physics, Chemistry & Biology"),
            new CallAreas("600 - 699", "Technology", "Inventions, Robots & Transportation"),
            new CallAreas("700 - 799", "The Arts", "Comics, Music & Sports"),
            new CallAreas("800 - 899", "Literature & Rhetoric", "Shakespeare, Classic Literature & Riddles"),
            new CallAreas("900 - 999", "History & Geography", "Exploration, Countries & Factual Events"),
        };

        Dictionary<String, String> areasDictionary = new Dictionary<String, String>();
        Dictionary<int, int> randomDictionary = new Dictionary<int, int>();

        List<int> randomAreas = new List<int>();
        List<int> userScores = new List<int>();
        List<String> userAreas = new List<String>();
        List<String> numberAreas = new List<String>();
        List<String> textAreas = new List<String>();

        int timerTicker, userScore, dataId;
        String valueOne;

        public WindowAreas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ON-WINDOW-LOADS, DO THESE:
        /// OPEN DATABSE AND FIND MINIMUM TIME-TO-BEAT.
        /// ENSURE COLUMNS ARE ENABLED.
        /// GENERATE RANDOM LISTS FROM DICTIONARY.
        /// START TIMER.
        /// CAN SWAP OUT COLUMSN INFROMATION.
        /// </summary>
        private void WindowAreas_Load(object sender, EventArgs e)
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

                ListText.Enabled = true;

                randomAreas.AddRange(wrench.RandomAreas());

                foreach(CallAreas area in callAreas)
                {
                    areasDictionary.Add(area.AreaNumber, area.AreaName);
                }

                foreach(int i in randomAreas)
                {
                    ListText.Items.Add(areasDictionary.ElementAt(i).Value);
                }

                for(int i = 0; i < 4; i++)
                {
                    ListNumbers.Items.Add(areasDictionary.ElementAt(randomAreas[i + 1]).Key);
                }

                TimerAreas.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// TIMER STARTS, DO THESE:
        /// CONTINOUS 1 SECOND TICK UNTIL STOPPED.
        /// CLEAR, FILL AND PASS LISTS WITH DICTIRONARY REFERNCES TO TOOLS CLASS.
        /// DISPLAYED RETURNED VALUE AS POINTS.
        /// </summary>
        private void TimerAreas_Tick(object sender, EventArgs e)
        {
            try
            {
                timerTicker++;
                TextTime.Text = timerTicker.ToString() + " Seconds";

                numberAreas.Clear();
                textAreas.Clear();
                userAreas.Clear();

                foreach (var item in ListNumbers.Items)
                {
                    numberAreas.Add(item.ToString());
                }

                foreach (var item in ListText.Items)
                {
                    textAreas.Add(item.ToString());
                }

                for (int i = 0; i < numberAreas.Count; i++)
                {
                    areasDictionary.TryGetValue(numberAreas[i], out valueOne);
                    userAreas.Add(valueOne);
                }

                userScore = wrench.CheckAreas(userAreas, textAreas);

                TextScore.Text = userScore.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DRAG & DROP:
        /// MOVE DATA FROM ONE INDEX LOCATION TO ANOTHER.
        /// MOVE EXISITNG DATA DOWN INDEX.
        /// </summary>
        private void ListText_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ListText.DoDragDrop(ListText.SelectedItem, DragDropEffects.Move);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ListText_DragOver(object sender, DragEventArgs e)
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

        private void ListText_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Point point = ListText.PointToClient(new Point(e.X, e.Y));
                int index = ListText.IndexFromPoint(point);
                if (index < 0)
                {
                    index = ListText.Items.Count - 1;
                }

                ListText.Items.Remove(e.Data.GetData(DataFormats.Text));
                ListText.Items.Insert(index, e.Data.GetData(DataFormats.Text));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// NAVIGATION CONTROLS FOR BACK & EXIT. ENSURE APPLICATION ENDS.
        /// ON COMPLETE:
        /// READ LIST OF IDS & CREATE SEQUENCIAL ID.
        /// SET ID, SCORE AND TIME.
        /// NOTIFY USER WITH UPDATES.
        /// IF USER DOESNT MEET MINIMUM, RESET.
        /// DISABLE GAME FEATURE.
        /// ON RESET:
        /// CLEAR TIMERS & RESTART.
        /// ENSURE GAME FEATURE IS ENABLED.
        /// CHECK FOR NEW TIME-TO-BEAT.
        /// </summary>
        private void ButtonComplete_Click(object sender, EventArgs e)
        {
            try
            {
                TimerAreas.Stop();

                if (userScore == 4)
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
                    //    ListText.Enabled = false;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Game Infromation Was NOT Recorded!", "Note", MessageBoxButtons.OK);
                    //}
                }
                else
                {
                    MessageBox.Show("You NEED A Score Of 4 Points To Submit!", "Note", MessageBoxButtons.OK);
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
                TimerAreas.Stop();
                timerTicker = 0;
                TextTime.Text = "0 Seconds";

                ListText.Items.Clear();

                foreach (int i in randomAreas)
                {
                    ListText.Items.Add(areasDictionary.ElementAt(i).Value);
                }

                //sqlConnection.ConnectionString = connectionString;
                //SqlCommand sqlCommand = new SqlCommand(readCommand, sqlConnection);
                //sqlConnection.Open();

                //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                //sqlDataReader.Read();
                //TextBeat.Text = sqlDataReader["DISPLAYTIME"].ToString() + " Seconds";

                //sqlConnection.Close();

                ListText.Enabled = true;

                TimerAreas.Start();
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

        private void WindowAreas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
