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
        /// <summary>
        /// DATABASE CONNECTION
        /// </summary>

        //String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibraryDatabase.mdf;Integrated Security = True";
        //String insertCommand = "INSERT INTO SORT (SORT_ID, SORT_TIME, SORT_SCORE) VALUES (@A, @B, @C);";
        //String readCommand = "SELECT MIN(SORT_TIME) AS DISPLAYTIME FROM SORT;";
        //String idCommand = "SELECT MAX(SORT_ID) AS DATAID FROM SORT;";

        //SqlConnection sqlConnection = new SqlConnection();

        /// <summary>
        /// GLOBAL VARIBLES
        /// </summary>

        Tools wrench = new Tools();
        Random random = new Random();

        TreeNode<CallAreas> treeRoot = SampleData.LoadDatatFile();

        private int levelCounter = 0;
        private int timerTicker;
        private string selectedItem;

        private List<string> treeCalls = new List<string>();

        public WindowCall()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ON-WINDOW-LOAD SELECT RANDOM 3RD LEVEL ITEM WITH PARENTS TILL ROOT.
        /// LOAD INTO LIST FOR REFRENCE.
        /// BASED ON COUNTER LEVEL, DISPLAY INFORMATION.
        /// START TIMER.
        /// </summary>
        private void WindowCall_Load(object sender, EventArgs e)
        {
            try
            {
                ///<summary>
                ///PRINT TEST FOR CONSOLE - OUTPUT
                /// </summary>
                /*foreach (TreeNode<CallAreas> node in treeRoot)
                {
                    string indent = CreateIndent(node.Level);
                    Console.WriteLine(indent + (node.Data.AreaNumber + " " + node.Data.AreaName));
                }*/

                treeCalls.AddRange(wrench.SelectRandomCall());
                TextSelectedCall.Text = treeCalls[0];

                if (levelCounter == 0)
                {
                    DisplayLevelOne();
                }
                if (levelCounter == 1)
                {
                    DisplayLevelTwo();
                }
                if (levelCounter == 2)
                {
                    DisplayLevelThree();
                }

                TimerCalls.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ///<summary>
        ///PRINT TEST FOR CONSOLE - STRUCTURE
        /// </summary>
        /*private static String CreateIndent(int depth)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < depth; i++)
            {
                sb.Append(' ');
            }
            return sb.ToString();
        }*/

        ///<summary>
        ///FUNCTION DISPLAYS LEVEL ONE NODES.
        ///CLEARS PREVIOUS SELECTIONS & ITEMS.
        /// </summary>
        public void DisplayLevelOne()
        {
            List<string> levelOne = new List<string>();
            int tempAmount = 0;

            try
            {
                ComboCalls.SelectedIndex = -1;
                ComboCalls.Items.Clear();

                foreach (TreeNode<CallAreas> node in treeRoot)
                {
                    if (node.Level == 1)
                    {
                        levelOne.Add(node.Data.AreaNumber + " " + node.Data.AreaName);
                    }
                }

                while (tempAmount < 4)
                {
                    tempAmount = ComboCalls.Items.Count;
                    int tempNumber = random.Next(0, 9);

                    if (!ComboCalls.Items.Contains(levelOne[tempNumber]))
                    {
                        ComboCalls.Items.Add(levelOne[tempNumber]);
                    }

                    TextMatch.Text = "Level " + 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ///<summary>
        ///FUNCTION DISPLAYS LEVEL TWO NODES.
        ///CLEARS PREVIOUS SELECTIONS & ITEMS.
        /// </summary>
        public void DisplayLevelTwo()
        {
            try
            {
                ComboCalls.SelectedIndex = -1;
                ComboCalls.Items.Clear();

                foreach (TreeNode<CallAreas> node in treeRoot)
                {
                    if (node.Level == 2)
                    {
                        ComboCalls.Items.Add(node.Data.AreaNumber + " " + node.Data.AreaName);

                        TextMatch.Text = "Level " + node.Level;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ///<summary>
        ///FUNCTION DISPLAYS LEVEL THREE NODES.
        ///CLEARS PREVIOUS SELECTIONS & ITEMS.
        /// </summary>
        public void DisplayLevelThree()
        {
            try
            {
                ComboCalls.SelectedIndex = -1;
                ComboCalls.Items.Clear();

                foreach (TreeNode<CallAreas> node in treeRoot)
                {
                    if (node.Level == 3)
                    {
                        ComboCalls.Items.Add(node.Data.AreaNumber + " " + node.Data.AreaName);

                        TextMatch.Text = "Level " + node.Level;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// RESET OF QUESTIONS WILL OCCUR, WHILE TIMER WILL NOT BE STOPPED.
        /// MESSEAGE DISPLAY RESET STAUTS WILL BE DISPLAYED TO USER.
        /// </summary>
        public void ResetOnError()
        {
            try
            {
                MessageBox.Show("Your Selection Was INCORRECT.", "Note", MessageBoxButtons.OK);
                DisplayLevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ON-TICK PROGRESS TICKER & UPDATE USERS INTERFACE.
        /// </summary>
        private void TimerCalls_Tick(object sender, EventArgs e)
        {
            try
            {
                timerTicker++;
                TextTime.Text = timerTicker.ToString() + " Seconds";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ///<summary>
        ///CHECK THE CURRENT OPERATION.
        ///PULL SELECTION FORM COMBO BOX, THEN SPLIT INTO STRING ARRAY ON SPACE.
        ///PREFORM SEARCH ITERATION ON TREE DATA, WHERE DATA CANNOT BE NULL, AND AREA NUMBER AND ARE AESCIRPTION MUST MATCH.
        ///IF MATCH, THEN CORRECT, ELSE RESET.
        ///</summary>
        private void ButtonComplete_Click(object sender, EventArgs e)
        {
            try
            {
                selectedItem = ComboCalls.SelectedItem.ToString();
                string[] tempSplit = selectedItem.Split();

                TreeNode<CallAreas> found = treeRoot.FindTreeNode(node => node.Data != null && node.Data.AreaNumber.Contains(tempSplit[0]) && node.Data.AreaName.Contains(tempSplit[1]));
                
                if(found.Level == 1)
                {
                    if (treeCalls[2] == found.Data.AreaName)
                    {
                        DisplayLevelTwo();
                    }
                    else { ResetOnError(); }
                }
                if (found.Level == 2)
                {
                    if (treeCalls[1] == found.Data.AreaName)
                    {
                        DisplayLevelThree();
                    }
                    else { ResetOnError(); }
                }
                if (found.Level == 3)
                {
                    if (treeCalls[0] == found.Data.AreaName)
                    {
                        //Submit();
                        TimerCalls.Stop();
                    }
                    else { ResetOnError(); }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ON-BUTTON CLICK STOP & RESET TIMER AS WELL AS RESET QUESTIONS.
        /// </summary>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            try
            {
                TimerCalls.Stop();
                timerTicker = 0;
                TextTime.Text = "0 Seconds";

                treeCalls.Clear();
                treeCalls.AddRange(wrench.SelectRandomCall());

                DisplayLevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// NAVIGATE TO MAIN WINDOW
        /// </summary>
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            try
            {
                WindowMain windowMain = new WindowMain();
                windowMain.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ON-BUTTON 'X' EXIT APPLICATION & ENSURE APPLICATION CLOSES
        /// </summary>
        private void WindowCall_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ButtonBack_Click_1(object sender, EventArgs e)
        {
            ButtonBack_Click(sender, e);
        }
    }
}
