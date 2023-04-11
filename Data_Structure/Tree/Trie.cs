namespace DataStructure
{
    public class TrieNode
    {
        public char data;
        public Boolean isEndofWord;
        public Dictionary<char, TrieNode> children;
        public TrieNode(char val)
        {
            this.data = val;
            isEndofWord = false;
            children = new Dictionary<char, TrieNode>();
        }
    }

    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode(' ');
        }

        // Insert String
        public void Insert(string word)
        {
            TrieNode currentNode = root;
            foreach (char c in word)
            {
                if (!currentNode.children.ContainsKey(c))
                {
                    currentNode.children[c] = new TrieNode(c);
                }
                currentNode = currentNode.children[c];
            }
            currentNode.isEndofWord = true;
        }

        // Search Trie
        public Boolean Search(string word)
        {
            TrieNode currentNode = root;
            foreach (char c in word)
            {
                if (!currentNode.children.ContainsKey(c))
                {
                    return false;
                }
                currentNode = currentNode.children[c];
            }
            return currentNode.isEndofWord;
        }

    }

}