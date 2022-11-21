using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibraryTrainer
{
    internal class SampleData
    {
        ///<summary>
        ///HARD CODED TEST DATA FOR FUNCTIONS TESTING.
        /// </summary>
        public static TreeNode<CallAreas> LoadTestData()
        {
            TreeNode<CallAreas> root = new TreeNode<CallAreas>(new CallAreas("ROOT", "ROOT"));
            {
                TreeNode<CallAreas> node0 = root.AddChild(new CallAreas("000", "General Infromaiton"));
                {
                    TreeNode<CallAreas> node00 = node0.AddChild(new CallAreas("010", "Bibliographies"));
                    TreeNode<CallAreas> node01 = node0.AddChild(new CallAreas("020", "ibrary And Information Sciences"));
                    {
                        TreeNode<CallAreas> node020 = node01.AddChild(new CallAreas("023", "Personnel Management"));
                        TreeNode<CallAreas> node021 = node01.AddChild(new CallAreas("027", "General Libraries"));
                    }
                }
                TreeNode<CallAreas> node1 = root.AddChild(new CallAreas("100", "Philosophy & Psychology"));
                {
                    TreeNode<CallAreas> node10 = node1.AddChild(new CallAreas("110", "Metaphysics"));
                    TreeNode<CallAreas> node11 = node1.AddChild(new CallAreas("120", "Epistemology"));
                    {
                        TreeNode<CallAreas> node110 = node11.AddChild(new CallAreas("121", "Epistemology (Theory Of Knowledge)"));
                        TreeNode<CallAreas> node111 = node11.AddChild(new CallAreas("124", "Teleology"));
                    }
                }
                TreeNode<CallAreas> node2 = root.AddChild(new CallAreas("200", "Religion"));
                {
                    TreeNode<CallAreas> node20 = node2.AddChild(new CallAreas("210", "Philosophy And Theory Of Religion"));
                    TreeNode<CallAreas> node21 = node2.AddChild(new CallAreas("230", "Christianity"));
                    {
                        TreeNode<CallAreas> node210 = node21.AddChild(new CallAreas("233", "Humankind"));
                        TreeNode<CallAreas> node211 = node21.AddChild(new CallAreas("236", "Eschatology"));
                    }
                }
                TreeNode<CallAreas> node3 = root.AddChild(new CallAreas("300", "Social Sciences"));
                {
                    TreeNode<CallAreas> node30 = node3.AddChild(new CallAreas("320", "Political Sciences"));
                    TreeNode<CallAreas> node31 = node3.AddChild(new CallAreas("340", "Law"));
                    {
                        TreeNode<CallAreas> node310 = node31.AddChild(new CallAreas("342", "Constitutional And Administrative Law "));
                        TreeNode<CallAreas> node311 = node31.AddChild(new CallAreas("344", "Labor, Social Service, Education, Cultural Law"));
                    }
                }
            }

            return root;
        }

        ///<summary>
        ///READS DATA FROM TEXT FILE WITH CSV.
        ///AFTER A LINE IS READ, ITS ASSIGNED LEVEL IS COMPARED TO PREFORM CERTIAN FUCNTIONS.
        ///0 - ONE OF THE 10 GENERAL CATEGORIES.
        ///1 - TARGET PARENT NODE IS EVALUATED BEFORE ASSIGNMENT TO PARENT NODE.
        ///2 - TARGET PARENT NODE IS EVALUATED BEFORE ASSIGNMENT TO PARENT NODE.
        /// </summary>
        public static TreeNode<CallAreas> LoadDatatFile()
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
    }
}
