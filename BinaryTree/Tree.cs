using System;

namespace BinaryTree
{
    public class Tree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public Tree<T> LeftTree { get; set; }
        public Tree<T> RightTree { get; set; }

        public Tree(T nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }

        public void Insert(T newItem)
        {
            if(this.NodeData.CompareTo(newItem) > 0)
            {
                // left tree
                if(this.LeftTree == null)
                {
                    this.LeftTree = new Tree<T>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            }
            else
            {
                // right tree
                if (this.RightTree == null)
                {
                    this.RightTree = new Tree<T>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }
        }

        public string WalkTree()
        {
            string result = "";

            if(this.LeftTree!=null)
            {
                result = this.LeftTree.WalkTree();
            }
            result += $" {this.NodeData.ToString()} ";
            if(this.RightTree!=null)
            {
                result += this.RightTree.WalkTree();
            }
            return result;
        }
    }
}
