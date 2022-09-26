using System.Diagnostics;

namespace Challenges.C0017_Print_Tree_Level
{
    class Node
    {
        public Node? left;
        public Node? right;
        public int data;

        public Node(int val)
        {
            this.data = val;
            this.left = null;
            this.right = null;
        }
    }


    class TreePrinter
    {
        Dictionary<int, List<Node>> cache = new Dictionary<int, List<Node>>();

        public string PrintLevel(Node root, int targetLevel)
        {
            if (cache.Count == 0)
            {
                cache.Add(0, new List<Node>() { root });
            }

            List<Node>? levelNodes = null;
            int startLevel;

            for (startLevel = targetLevel; startLevel >= 0; startLevel--)
            {
                if (cache.TryGetValue(startLevel, out levelNodes))
                {
                    break;
                }
            }

            if (levelNodes != null && startLevel < targetLevel)
            {
                CacheToLevel(levelNodes, startLevel, targetLevel);
                cache.TryGetValue(targetLevel, out levelNodes);
            }

            var result = GetLevelString(levelNodes);
            return result;
        }

        private string GetLevelString(List<Node> levelNodes)
        {
            string result = "";
            foreach (Node n in levelNodes)
            {
                result += $"{n.data}, ";
            }

            return result.Trim();
        }

        private void CacheToLevel(List<Node> levelNodes, int currLevel, int targetLevel)
        {
            if (currLevel >= targetLevel)
            {
                return;
            }

            int nextLevel = currLevel + 1;

            if (!cache.ContainsKey(nextLevel))
            {
                cache.Add(nextLevel, new List<Node>());
            }

            foreach (var item in levelNodes)
            {
                if (item.left != null)
                    cache[nextLevel].Add(item.left);

                if (item.right != null)
                    cache[nextLevel].Add(item.right);
            }

            CacheToLevel(cache[nextLevel], nextLevel, targetLevel);
        }
    }
}
