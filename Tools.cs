using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrainer
{
    internal class Tools
    {
        /// <summary>
        /// VARIBLES
        /// </summary>
        Random random = new Random();

        TreeNode<CallAreas> treeRoot = SampleData.LoadTestData();

        /// <summary>
        /// GENERATES SINGLE ITEM OF DEWEY DECIMAL VALUES FORMAT XXX.XXX.XXX
        /// </summary>
        public string GenerateDecimal()
        {
            List<string> characters = new List<string>();

            int valueOne;
            char valueTwo;
            string deweyValue;

            for (int i = 0; i < 3; i++)
            {
                characters.Add(random.Next(0, 9).ToString());
            }

            characters.Add(".");

            for (int y = 0; y < 3; y++)
            {
                characters.Add(random.Next(0, 9).ToString());
            }

            characters.Add(" ");

            for (int x = 0; x < 3; x++)
            {
                valueOne = random.Next(65, 90);
                valueTwo = (char)valueOne;
                characters.Add(valueTwo.ToString());
            }

            deweyValue = String.Join("", characters);

            return deweyValue;
        }

        /// <summary>
        /// CHECKS OPERATION TO ASSIGN POINTS TO USERS
        /// </summary>
        public int CheckDecimal(List<String> controlList, List<String> userList)
        {
            List<int> checkList = new List<int>();
            int valueOne = 0;

            checkList.Clear();

            for (int i = 0; i < userList.Count; i++)
            {
                if (controlList[i].Equals(userList[i]))
                {
                    checkList.Add(1);
                }
                else
                {
                    checkList.Add(0);
                }
            }

            foreach (int check in checkList)
            {
                valueOne = valueOne + check;
            }

            return valueOne;
        }

        /// <summary>
        /// GENERATES LIST OF RANDOM INTEGERS TO USE IN PULLING VALUES FROM DICTIONARY
        /// </summary>
        public List<int> RandomAreas()
        {
            List<int> listOne = new List<int>();
            int randomNumber;

            for(int i = 0; i < 7; i++)
            {
                randomNumber = random.Next(9);

                if (!listOne.Contains(randomNumber))
                {
                    System.Threading.Thread.Sleep(10);
                    listOne.Add(randomNumber);
                    System.Threading.Thread.Sleep(10);
                }
                else
                {
                    i--;
                }
            }

            return listOne;
        }

        /// <summary>
        /// CHECKS OPERATION TO ASSIGN POINTS TO USERS
        /// </summary>
        public int CheckAreas(List<String> areaList, List<String> textList)
        {
            List<int> checkList = new List<int>();
            int valueTwo = 0;

            checkList.Clear();

            for (int i = 0; i < areaList.Count; i++)
            {
                if (areaList[i].Equals(textList[i]))
                {
                    checkList.Add(1);
                }
                else
                {
                    checkList.Add(0);
                }
            }

            foreach (int check in checkList)
            {
                valueTwo = valueTwo + check;
            }

            return valueTwo;
        }

        ///<summary>
        ///SELECT RANDOM CALL NAME BY PULLING DATA FROM TREE, THEN STORING IN LIST.
        ///STORE CALL NAME, CALL NAME PARENT AND CALL NAME GRANDPARENT.
        ///USE RANDOM NUMBER GENERATOR TO SELECT CALL NAME.
        /// </summary>
        public List<string> SelectRandomCall()
        {
            List<string> treeCalls = new List<string>();
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
            treeCalls.Add(tempListOne[tempValue]);
            treeCalls.Add(tempListTwo[tempValue]);
            treeCalls.Add(tempListThree[tempValue]);

            return treeCalls;
        }
    }
}
