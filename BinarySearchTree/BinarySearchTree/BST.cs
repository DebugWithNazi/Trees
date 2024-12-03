using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class TreeNode
    {
        public int Value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int value) 
        {
            this.Value = value;
            this.left = null;
            this.right = null;
        }
    }
    public class BST
    {
        public TreeNode Root;

        public void Insert(int value)
        {
            Root = InsertNode(Root, value);
        }

        public TreeNode InsertNode(TreeNode node, int value)
        {
            if(node == null)
            {
                return new TreeNode(value);
            }

            if(value < node.Value)
            {
                node.left = InsertNode(node.left, value);
            }
            else
            {
                node.right = InsertNode(node.right, value);
            }
            return node;
        }

        public bool Search(int value)
        {
            return SearchNode(Root,value);         
        }

        public bool SearchNode(TreeNode node, int value)
        {
            if(node == null)
            {
                return false;
            }

            if(node.Value == value)
            {
                return true;
            }
            else if(value < node.Value)
            {
                return SearchNode(node.left, value);
            }
            else
            {
                return SearchNode(node.right, value);
            }
        }
        public void InOrder()
        {
            InOrderTraversal(Root);
        }
        public void InOrderTraversal(TreeNode node)
        {
            if(node!= null)
            {
                InOrderTraversal(node.left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.right);
            }
        }

    }
}
