using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTreeNode
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public IList<TreeNode<T>> ChildNodes { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            this.ChildNodes = new List<TreeNode<T>>();
        }

        public TreeNode(T value, params TreeNode<T>[] childNodes)
        {
            this.Value = value;
            this.ChildNodes = new List<TreeNode<T>>();
            foreach (var child in childNodes)
                this.ChildNodes.Add(child);
        }

        private string Traverse(int level = 0)
        {
            var result = new StringBuilder();
            result.Append(new string(' ', level *2));
            result.Append(this.Value);
            result.Append(Environment.NewLine);
            foreach (var child in this.ChildNodes)
                result.Append(child.Traverse(level + 1));
            return result.ToString();
        }

        public override string ToString()
        {
            return Traverse();
        }
    }
}
