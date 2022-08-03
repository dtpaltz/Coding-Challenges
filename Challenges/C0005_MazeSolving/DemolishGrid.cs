using CommonLibrary.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.C0005_MazeSolving
{
    internal class DemolishGrid
    {
        private int[,] _grid;
        private GridCalculator<int> _gw;

        public DemolishGrid()
        {
            _gw = new GridCalculator<int>(-1);

            _grid = new int[,]
            {
                { 0, 0, 0, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 1, 0, 0, 0 }
            };
        }

        public bool IsGridSolvable()
        {
            bool canSolve = false;
            int demolishesRemaining = 1;
            var aWalls = FindWalls(new GridPosition(0, 0));
            var bWalls = FindWalls(new GridPosition(7, 7));

            foreach (var item in aWalls)
            {
                if (bWalls.Contains(item))
                {
                    canSolve = --demolishesRemaining == 0;
                }
            }

            return canSolve;
        }

        private HashSet<string> FindWalls(GridPosition fromPosition)
        {
            var foundWalls = new HashSet<string>();
            var visitedPositions = new HashSet<string>();
            var queue = new Queue<GridPosition>();

            queue.Enqueue(fromPosition);

            while (queue.Count > 0)
            {
                var thisPosition = queue.Dequeue();

                var nextPositions = _gw.GetValidNextMoves(_grid, thisPosition, new List<int>() { 0, 1 }, false);

                foreach (var item in nextPositions)
                {
                    if (!visitedPositions.Contains(item.ToString()))
                    {
                        int pVal = _grid[item.RowIdx, item.ColIdx];

                        if (pVal == 0)
                        {
                            queue.Enqueue(item);
                        }
                        else if (pVal == 1)
                        {
                            foundWalls.Add(item.ToString());
                        }

                        visitedPositions.Add(item.ToString());
                    }
                }
            }

            return foundWalls;
        }
    }
}
