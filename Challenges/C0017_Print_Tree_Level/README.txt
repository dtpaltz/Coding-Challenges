/*
          0
        /   \
       1     2
     /   \     \
    3     4      5

    printLevel (int levelNumber);
    
    printLevel (1) // 1 2
    printLevel (2) // 3 4 5

1. We should not parse tree for same level twice - pick from cache
2. We should not start from root all the time. Lets say we have
    level 1, 3, 5, and 10 in this case if we need level 7,
    then we do not start from root, rather from level 5
*/

using System;

class Node {
    public Node left;
    public Node right;
    public int val;
    public Node(int val) {
        this.val = val;
        this.left = null;
        this.right = null;
    }
}

class Solution {
    static void Main(string[] args) {
        Node root = new Node (0);
        root.left = new Node (1);
        root.right = new Node (2);
        root.left.left = new Node (3);
        root.left.right = new Node (4);
        root.right.right = new Node (5);
    }
}


class TreePrinter
{
  Dictionary<int, List<Node>> levelCache = new Dictionary<int, List<Node>>();
  
  public void printLevel(Node root, int levelNumber)
  {
	for (int i = levelNumber; i >= 0; i--)
	{
		if (levelCache.ContainsKey(levelNumber))
		{
			var level
			printAtLevel(r
		}
	}
  }
  
  private void printAtLevel(Node root, int targetLevel, int currLevel)
  {
    if (root == null) return;
    
    if (currLevel == targetLevel)
    {
      Console.Write(root.val);
    }
    else
    {
      printAtLevel(root.left, targetLevel, currLevel + 1);
      printAtLevel(root.right, targetLevel, currLevel + 1);
    }
  }
}












