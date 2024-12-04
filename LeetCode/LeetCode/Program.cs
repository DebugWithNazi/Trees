
using LeetCode;

Solution solution = new Solution();

// Insert values to construct the tree with structure [1, null, 2, 3]
solution.Insert(1);
solution.Insert(2);
solution.Insert(3);
solution.Insert(4);
solution.Insert(5);
solution.Insert(8);
solution.Insert(6);
solution.Insert(7);
solution.Insert(9);

// Print the inorder traversal of the tree
Console.WriteLine("Inorder Traversal of the Tree:");
solution.Inorder();
