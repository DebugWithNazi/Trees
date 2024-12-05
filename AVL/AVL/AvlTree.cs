using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AVL
{
    public class AvlTree
    {
        public class TreeNode
        {
            public int Value;
            public TreeNode? Left;
            public TreeNode? Right;
            public int Height;
            public TreeNode(int value)
            {
                this.Value = value;
                this.Height = 1;
            }
        }

        public TreeNode? Root;

        public int GetHeight(TreeNode? node)
        {
            return node == null ? 0 : node.Height;
        }
        public int GetBalance(TreeNode? node)
        {
            return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
        }

        public void Insert(int value)
        {
            Root = Insert(Root, value);
        }
        public TreeNode Insert(TreeNode? node, int value)
        {
            if (node == null)
            {
                return new TreeNode(value);
            }

            if (value < node.Value)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Insert(node.Right, value);
            }
            else
            {
                return node;
            }

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
            int balance = GetBalance(node);

            if (balance > 1 && value < node.Left.Value)
            {
                return RotateRight(node);
            }
            else if (balance < -1 && value > node.Right.Value)
            {
                return RotateLeft(node);
            }
            else if (balance > 1 && value > node.Left.Value)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }
            else if (balance < -1 && value < node.Right.Value)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }
            return node;
        }

        public TreeNode RotateRight(TreeNode x)
        {
            TreeNode y = x.Left;
            TreeNode T2 = y.Right;

            y.Right = x;
            x.Left = T2;

            x.Height = Math.Max(GetHeight(x.Left), GetHeight(y.Right)) + 1;
            y.Height = Math.Max(GetHeight(x.Left), GetHeight(y.Right)) + 1;

            return y;
        }
        public TreeNode RotateLeft(TreeNode y)
        {
            TreeNode x = y.Right;
            TreeNode T2 = x.Left;

            x.Left = y;
            y.Right = T2;

            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right));
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right));
            return x;
        }

        public void Inorder(TreeNode node)
        {
            if (node != null)
            {
                Inorder(node.Left);
                Console.Write(node.Value + " ");
                Inorder(node.Right);
            }
        }

       public void PrintInOrder()
        {
            Console.WriteLine("Inorder Traversal of the tree");
            Inorder(Root);
            Console.WriteLine();
        }
    }
}
