using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryTrainer
{
    internal class TreeNode<T> : IEnumerable<TreeNode<T>>
    {
        //DATA STORED IN NODE
        public T Data { get; set; }
        //REFERNCE TO PARENT NODE
        public TreeNode<T> Parent { get; set; }
        //REFERNCE TO CHILD NODES
        public List<TreeNode<T>> Children { get; set; }

        //RETURNS LEVEL OF NODE
        public int Level
        {
            get
            {
                if (this.IsRoot)
                    return 0;
                return Parent.Level + 1;
            }
        }

        //CHECKS IF NODE IS THE ROOT
        public Boolean IsRoot
        {
            get { return Parent == null; }
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<TreeNode<T>> GetEnumerator()
        {
            yield return this;
            foreach (var directChild in this.Children)
            {
                foreach (var anyChild in directChild)
                    yield return anyChild;
            }
        }

    }
}
