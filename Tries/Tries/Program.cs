using Tries;

Trie trie = new Trie();
trie.Insert("apple");
trie.Insert("app");
trie.Insert("banana");

Console.WriteLine(trie.Search("apple"));  
Console.WriteLine(trie.Search("app"));     
Console.WriteLine(trie.Search("appl"));  

Console.WriteLine(trie.StartsWith("app")); 
Console.WriteLine(trie.StartsWith("ban")); 
Console.WriteLine(trie.StartsWith("bat"));