using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryTrainer
{
    internal class TreeNode<T>
    {
        //DATA STORED IN NODE
        public T Data { get; set; }
        //REFERNCE TO PARENT NODE
        public TreeNode<T> Parent { get; set; }
        //REFERNCE TO CHILD NODES
        public List<TreeNode<T>> Children { get; set; }

        //RETURNS HEIGHT OF NODE
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }

        //CONSTRUCTOR FOR EXPECTED DATA
        public TreeNode(T data)
        {
            this.Data = data;
            this.Children = new List<TreeNode<T>>();
        }

        public TreeNode<T> AddChild(T child)
        {
            TreeNode<T> childNode = new TreeNode<T>(child) { Parent = this };
            this.Children.Add(childNode);

            return childNode;
        }

    }
}
