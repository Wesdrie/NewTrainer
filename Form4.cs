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
        Random random = new Random();

        TreeNode<CallAreas> treeRoot = SampleData.LoadTestData();

        private int levelCounter = 0;
        private string selectedCall, selectedParent, selectedGrandParent, selectedItem;

        public WindowCall()
        {
            InitializeComponent();
        }

        private void WindowCall_Load(object sender, EventArgs e)
        {
            try
            {
                //LoadDatatFile();

                SelectRandomCall();

                if(levelCounter == 0)
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        ///<summary>
        ///SELECT RANDOM CALL NAME BY PULLING DATA FROM TREE, THEN STORING IN LIST.
        ///STORE CALL NAME, CALL NAME PARENT AND CALL NAME GRANDPARENT.
        ///USE RANDOM NUMBER GENERATOR TO SELECT CALL NAME.
        /// </summary>
        public void SelectRandomCall()
        {
            List<string> tempListOne = new List<string>();
            List<string> tempListTwo = new List<string>();
            List<string> tempListThree = new List<string>();
            int tempValue;

            foreach (TreeNode<CallAreas> node in treeRoot)
            {
                if (node.Level == 3)
                {
                    tempListOne.Add(node.Data.AreaName);
                    tempListTwo.Add(node.Parent.Data.AreaName);
                    tempListThree.Add(node.Parent.Parent.Data.AreaName);
                }
            }

            tempValue = random.Next(tempListOne.Count);
            selectedCall = tempListOne[tempValue];
            selectedParent = tempListTwo[tempValue];
            selectedGrandParent = tempListThree[tempValue];

            TextSelectedCall.Text = selectedCall;
        }

        ///<summary>
        ///FUNCTION DISPLAYS LEVEL ONE NODES.
        ///CLEARS PREVIOUS SELECTIONS & ITEMS.
        /// </summary>
        public void DisplayLevelOne()
        {
            ComboCalls.SelectedIndex = -1;
            ComboCalls.Items.Clear();

            foreach (TreeNode<CallAreas> node in treeRoot)
            {
                if (node.Level == 1)
                {
                    ComboCalls.Items.Add(node.Data.AreaNumber + " " + node.Data.AreaName);

                    TextMatch.Text = "Level " + node.Level;
                }
            }
        }

        ///<summary>
        ///FUNCTION DISPLAYS LEVEL TWO NODES.
        ///CLEARS PREVIOUS SELECTIONS & ITEMS.
        /// </summary>
        public void DisplayLevelTwo()
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

        ///<summary>
        ///FUNCTION DISPLAYS LEVEL THREE NODES.
        ///CLEARS PREVIOUS SELECTIONS & ITEMS.
        /// </summary>
        public void DisplayLevelThree()
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

        /// <summary>
        /// RESET OF QUESTIONS WILL OCCUR, WHILE TIMER WILL NOT BE STOPPED.
        /// MESSEAGE DISPLAY RESET STAUTS WILL BE DISPLAYED TO USER.
        /// </summary>
        public void ResetOnError()
        {
            //NEEDS MESSAGE
            DisplayLevelOne();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            DisplayLevelOne();
        }

        ///<summary>
        ///READS DATA FROM TEXT FILE WITH CSV.
        ///AFTER A LINE IS READ, ITS ASSIGNED LEVEL IS COMPARED TO PREFORM CERTIAN FUCNTIONS.
        ///0 - ONE OF THE 10 GENERAL CATEGORIES.
        ///1 - TARGET PARENT NODE IS EVALUATED BEFORE ASSIGNMENT TO PARENT NODE.
        ///2 - TARGET PARENT NODE IS EVALUATED BEFORE ASSIGNMENT TO PARENT NODE.
        /// </summary>
        /*public void LoadDatatFile()
        {
            try
            {
                int valueOne = 0;
                int valueTwo = 0;

                Tree<CallAreas> tree = new Tree<CallAreas>();
                tree.Root = new TreeNode<CallAreas>()
                {
                    Data = new CallAreas("Root", "Root"),
                    Parent = null
                };

                foreach (string line in File.ReadLines(@"C:\TestData.txt"))
                {
                    string[] values = line.Split(',');
                    List<string> list = new List<string>();

                    if (values[0].Contains("0"))
                    {
                        tree.Root.Children = new List<TreeNode<CallAreas>>
                        {
                            new TreeNode<CallAreas>()
                            {
                                Data = new CallAreas(values[2], values[3]),
                                Parent = tree.Root
                            }
                        };

                        Console.WriteLine(values[2] + " " + values[3] + " " + valueOne);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(tree.Root.Children[i].ToString());
                    }

                    if (values[0].Contains("1"))
                    {
                        if (values[1].Equals("000")) { valueOne = 0; }
                        if (values[1].Equals("100")) { valueOne = 1; }
                        if (values[1].Equals("200")) { valueOne = 2; }
                        if (values[1].Equals("300")) { valueOne = 3; }
                        if (values[1].Equals("400")) { valueOne = 4; }
                        if (values[1].Equals("500")) { valueOne = 5; }
                        if (values[1].Equals("600")) { valueOne = 6; }
                        if (values[1].Equals("700")) { valueOne = 7; }
                        if (values[1].Equals("800")) { valueOne = 8; }
                        if (values[1].Equals("900")) { valueOne = 9; }

                        tree.Root.Children[valueOne].Children = new List<TreeNode<CallAreas>>
                         {
                             new TreeNode<CallAreas>()
                             {
                                 Data = new CallAreas(values[2], values[3]),
                                 Parent = tree.Root.Children[valueOne]
                             }
                         };

                        Console.WriteLine("\t" + values[2] + " " + values[3]);
                    }
                    if (values[0].Contains("2"))
                    {
                        int valueThree = Int16.Parse(values[1]);

                        if (valueThree >= 0 && valueThree < 100) { valueOne = 0; }
                        if (valueThree >= 100 && valueThree < 200) { valueOne = 1; }
                        if (valueThree >= 200 && valueThree < 300) { valueOne = 2; }
                        if (valueThree >= 300 && valueThree < 400) { valueOne = 3; }
                        if (valueThree >= 400 && valueThree < 500) { valueOne = 4; }
                        if (valueThree >= 500 && valueThree < 600) { valueOne = 5; }
                        if (valueThree >= 600 && valueThree < 700) { valueOne = 6; }
                        if (valueThree >= 700 && valueThree < 800) { valueOne = 7; }
                        if (valueThree >= 800 && valueThree < 900) { valueOne = 8; }
                        if (valueThree >= 900 && valueThree < 1000) { valueOne = 9; }

                        tree.Root.Children[valueOne].Children[valueTwo].Children = new List<TreeNode<CallAreas>>
                         {
                             new TreeNode<CallAreas>()
                             {
                                 Data = new CallAreas(values[2], values[3]),
                                 Parent = tree.Root.Children[valueOne].Children[valueTwo]
                             }
                         };

                        Console.WriteLine("\t\t" + values[2] + " " + values[3]);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }*/


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
                    if(selectedGrandParent == found.Data.AreaName)
                    {
                        DisplayLevelTwo();
                    }
                    else { ResetOnError(); }
                }
                if (found.Level == 2)
                {
                    if (selectedParent == found.Data.AreaName)
                    {
                        DisplayLevelThree();
                    }
                    else { ResetOnError(); }
                }
                if (found.Level == 3)
                {
                    if (selectedCall == found.Data.AreaName)
                    {
                        //Submit();
                    }
                    else { ResetOnError(); }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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
