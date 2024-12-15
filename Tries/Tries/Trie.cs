using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children {  get; set; }
        public bool IsEndOfWord {  get; set; }
        public TrieNode() 
        {
            Children = new Dictionary<char, TrieNode>();
            IsEndOfWord = false;
        }
    }
    public class Trie
    {
        private TrieNode root;
        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode current = root;
            foreach(char ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    current.Children[ch] = new TrieNode();
                }
                current = current.Children[ch];
            }
            current.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            TrieNode current = root;
            foreach(char ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    return false;
                }
                current = current.Children[ch];
            }
            return current.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode current = root;
            foreach(char ch in prefix)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    return false;
                }
                current = current.Children[ch];
            }
            return true;
        }
    }
}
