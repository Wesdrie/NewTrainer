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
    }
}
