using System;

namespace LeetcodeAnswer.Scripts
{
    /// <summary>
    /// 前缀树可用于只能提示~
    /// </summary>
    public static class PrefixTree
    {
        public static void Entry()
        {
            var trie = new Trie();
            trie.insert("interivew");
            var search = trie.search("in");
            var startWith = trie.startsWith("riv");
            Console.WriteLine("over");
        }
    }

    /// <summary>
    /// 前缀树
    /// </summary>
    class Trie
    {
        private Trie[] children;
        private bool isEnd;

        public Trie()
        {
            children = new Trie[26];
            isEnd = false;
        }

        public void insert(string word)
        {
            Trie node = this;
            for (var i = 0; i < word.Length; i++)
            {
                char ch = word[i];
                int index = ch - 'a';
                if (node.children[index] == null)
                {
                    node.children[index] = new Trie();
                }

                node = node.children[index];
            }
            node.isEnd = true;
        }

        public bool search(string word)
        {
            Trie node = searchPrefix(word);
            return node != null && node.isEnd;
        }

        public bool startsWith(string prefix)
        {
            Trie node = searchPrefix(prefix);
            return node != null;
        }

        private Trie searchPrefix(string prefix)
        {
            Trie node = this;
            for (var i = 0; i < prefix.Length; i++)
            {
                char ch = prefix[i];
                int index = ch - 'a';
                if (node.children[index] == null)
                {
                    return null;
                }

                node = node.children[index];
            }

            return node;
        }
    }
}