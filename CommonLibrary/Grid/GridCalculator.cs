namespace CommonLibrary.Grid
{
    public class GridCalculator<T>
    {
        public T? OutOfBoundsDefaultValue { get; private set; }

        public GridCalculator(T? outOfBoundsDefaultValue)
        {
            OutOfBoundsDefaultValue = outOfBoundsDefaultValue;
        }

        public T? GetNeighborValue(T[,] grid, GridPosition currPosition, Direction neighborDirection)
        {
            try
            {
                switch (neighborDirection)
                {
                    case Direction.Left:
                        return grid[currPosition.RowIdx, currPosition.ColIdx - 1];
                    case Direction.Up:
                        return grid[currPosition.RowIdx - 1, currPosition.ColIdx];
                    case Direction.Right:
                        return grid[currPosition.RowIdx, currPosition.ColIdx + 1];
                    case Direction.Down:
                        return grid[currPosition.RowIdx + 1, currPosition.ColIdx];
                }

            }
            catch (IndexOutOfRangeException)
            {
                // do nothing
            }

            return OutOfBoundsDefaultValue;
        }

        public bool IsPositionInBounds(T[,] grid, GridPosition currPosition)
        {
            try
            {
                var temp = grid[currPosition.RowIdx, currPosition.ColIdx];
                return true;
            }
            catch (Exception)
            {
                // do nothing
            }

            return false;
        }

        public GridPosition GetNeighborPosition(T[,] grid, GridPosition currPosition, Direction neighborDirection)
        {
            switch (neighborDirection)
            {
                case Direction.Left:
                    return new GridPosition(currPosition.RowIdx, currPosition.ColIdx - 1);
                case Direction.Up:
                    return new GridPosition(currPosition.RowIdx - 1, currPosition.ColIdx);
                case Direction.Right:
                    return new GridPosition(currPosition.RowIdx, currPosition.ColIdx + 1);
                case Direction.Down:
                    return new GridPosition(currPosition.RowIdx + 1, currPosition.ColIdx);


                case Direction.UpperLeft:
                    return new GridPosition(currPosition.RowIdx - 1, currPosition.ColIdx - 1);
                case Direction.UpperRight:
                    return new GridPosition(currPosition.RowIdx - 1, currPosition.ColIdx + 1);
                case Direction.LowerRight:
                    return new GridPosition(currPosition.RowIdx + 1, currPosition.ColIdx + 1);
                case Direction.LowerLeft:
                    return new GridPosition(currPosition.RowIdx + 1, currPosition.ColIdx - 1);
            }

            return null;
        }

        public List<GridPosition> GetValidNextMoves(T[,] grid, GridPosition currPosition, List<T> validPositionValues, bool includeDiagonalNeighbors)
        {
            var validMoves = new List<GridPosition>();

            int nCount = includeDiagonalNeighbors ? 8 : 4;

            for (int i = 0; i < nCount; i++)
            {
                var tempPos = GetNeighborPosition(grid, currPosition, (Direction)i);

                if (tempPos != null && IsPositionInBounds(grid, tempPos) && validPositionValues.Contains(grid[tempPos.RowIdx, tempPos.ColIdx]))
                {
                    validMoves.Add(GetNeighborPosition(grid, currPosition, (Direction)i));
                }
            }

            return validMoves;
        }
    }

    public enum Direction
    {
        Left,
        Up,
        Right,
        Down,
        UpperLeft,
        UpperRight,
        LowerRight,
        LowerLeft
    }

    public class GridPosition
    {
        public int RowIdx { get; set; }

        public int ColIdx { get; set; }

        public GridPosition(int rowIdx, int colIdx)
        {
            RowIdx = rowIdx;
            ColIdx = colIdx;
        }

        public override string ToString()
        {
            return $"[ {RowIdx}, {ColIdx} ]";
        }
    }
}
