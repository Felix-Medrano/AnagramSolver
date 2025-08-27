namespace AnagramSolver.TriePattern
{
  public class Trie
  {
    public readonly TrieNode root;

    public Trie()
    {
      root = new TrieNode();
    }

    public void Insert(string word)
    {
      var node = root;

      foreach (char c in word.ToLower())
      {
        if (!node.Children.ContainsKey(c))
          node.Children[c] = new TrieNode();

        node = node.Children[c];
      }

      node.IsEndOfWord = true;
    }


    public bool Search(string word)
    {
      var node = root;
      foreach (char c in word.ToLower())
      {
        if (!node.Children.ContainsKey(c))
          return false;
        node = node.Children[c];
      }

      return node.IsEndOfWord;
    }
  }
}
