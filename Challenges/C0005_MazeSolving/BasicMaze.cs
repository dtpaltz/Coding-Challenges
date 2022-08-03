using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.C0005_MazeSolving
{
    internal class BasicMaze<T>
    {
        private T[,] _currentState;

        public BasicMaze(T[,] currentState)
        {
            _currentState = currentState;
        }

        public bool CanSolve()
        {
            for (int i = 0; i < _currentState.GetLength(0); i++)
            {
                for (int j = 0; j < _currentState.GetLength(1); j++)
                {
                    var currCell = _currentState[i, j];
                }
            }

            return false;
        }
    }
}
