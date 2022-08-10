using System.Diagnostics;

namespace Challenges.C0017_Print_Tree_Level
{
    class Node
    {
        public Node left;
        public Node right;
        public int val;
        public Node(int val)
        {
            this.val = val;
            this.left = null;
            this.right = null;
        }
    }




    class TreePrinter
    {
        Dictionary<int, List<Node>> cache = new Dictionary<int, List<Node>>();

        public void PrintLevel(Node root, int targetLevel)
        {
            List<Node> levelNodes;
            int startLevel;

            for (startLevel = targetLevel; !cache.TryGetValue(startLevel, out levelNodes); startLevel--)
            {
                cache.Add(startLevel, new List<Node>() { });

                if (startLevel == 0)
                {
                    break;
                }
            }

            if (startLevel == 0)
            {
                CacheToLevel(root, startLevel, targetLevel);
                cache.TryGetValue(targetLevel, out levelNodes);
            }

            foreach (Node n in levelNodes)
            {
                Debug.Write(n.val + " ");
            }

            Debug.WriteLine("");
        }

        private void CacheToLevel(Node root, int currLevel, int targetLevel)
        {
            if (root == null || currLevel > targetLevel) return;

            cache[currLevel].Add(root);
            CacheToLevel(root.left, currLevel + 1, targetLevel);
            CacheToLevel(root.right, currLevel + 1, targetLevel);
        }
    }
}
