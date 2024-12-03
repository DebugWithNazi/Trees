using BinarySearchTree;

BST bst = new BST();
bst.Insert(50);
bst.Insert(30);
bst.Insert(70);
bst.Insert(20);
bst.Insert(40);
bst.Insert(60);
bst.Insert(80);

Console.Write("Inorder Traversal: ");
bst.InOrder();
Console.WriteLine();
Console.WriteLine("Search for 40: " + bst.Search(40));
Console.WriteLine("Search for 25: " + bst.Search(25));