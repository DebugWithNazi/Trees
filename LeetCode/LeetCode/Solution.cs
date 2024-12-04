using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        public IList<int> list = new List<int>();
        public TreeNode root;
        public void Insert(int value)
        {
            root = InsertNode(root, value);
        }

        public TreeNode InsertNode(TreeNode node, int value)
        {
            if(node == null)
            {
                return new TreeNode(value);
            }
            if(value < node.val)
            {
                node.left = InsertNode(node.left, value);
            }
            else if(value > node.val)
            {
                node.right = InsertNode(node.right, value);
            }
            return node;
        }
       
        public void Inorder()
        {
            IList<int> list = InorderTraversal(root);
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if(i < list.Count - 1)
                {
                    Console.Write(",");
                }
            }
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            if(root != null)
            {
                InorderTraversal(root.left);
                list.Add(root.val);
                InorderTraversal(root.right);
            }
            return list;
        }
    }
}
