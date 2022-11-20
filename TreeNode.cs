using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
