using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryTrainer
{
    public class TreeNode<kPair, vPair> : IEnumerable<TreeNode<kPair, vPair>>
    {
        public kPair kData { get; set; }
        public vPair vData { get; set; }
        public TreeNode<kPair, vPair> Parent { get; set; }
        public ICollection<TreeNode<kPair, vPair>> Children { get; set; }

        public Boolean IsRoot
        {
            get { return Parent == null; }
        }

        public Boolean IsLeaf
        {
            get { return Children.Count == 0; }
        }

        public int Level
        {
            get
            {
                if (this.IsRoot)
                    return 0;
                return Parent.Level + 1;
            }
        }

        public TreeNode(kPair kData, vPair vData)
        {
            this.kData = kData;
            this.vData = vData;

            this.Children = new LinkedList<TreeNode<kPair, vPair>>();

            this.ElementsIndex = new LinkedList<TreeNode<kPair, vPair>>();
            this.ElementsIndex.Add(this);
        }

        public TreeNode<kPair, vPair> AddChild(kPair kData, vPair vData)
        {
            TreeNode<kPair, vPair> childNode = new TreeNode<kPair, vPair>(kData, vData) { Parent = this };
            this.Children.Add(childNode);

            this.RegisterChildForSearch(childNode);

            return childNode;
        }

        private ICollection<TreeNode<kPair, vPair>> ElementsIndex { get; set; }

        private void RegisterChildForSearch(TreeNode<kPair, vPair> node)
        {
            ElementsIndex.Add(node);
            if (Parent != null)
                Parent.RegisterChildForSearch(node);
        }

        public TreeNode<kPair, vPair> FindTreeNode(Func<TreeNode<kPair, vPair>, bool> predicate)
        {
            return this.ElementsIndex.FirstOrDefault(predicate);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<TreeNode<kPair, vPair>> GetEnumerator()
        {
            yield return this;
            foreach (var directChild in this.Children)
            {
                foreach (var anyChild in directChild)
                {
                    yield return anyChild;
                }  
            }
        }
    }
}