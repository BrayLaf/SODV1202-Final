namespace Connect4_game
{
    public class Board
    {
        private const int Rows = 6;
        private const int Cols = 7;
        private char[,] grid = new char[Rows, Cols];

        public Board()
        {
            for (int r = 0; r < Rows; r++)
                for (int c = 0; c < Cols; c++)
                    grid[r, c] = '.';
        }

        public bool DropDisc(int col, char symbol)
        {
            for (int r = Rows - 1; r >= 0; r--)
            {
                if (grid[r, col] == '.')
                {
                    grid[r, col] = symbol;
                    return true;
                }
            }
            return false;
        }

        public bool IsFull()
        {
            for (int c = 0; c < Cols; c++)
                if (grid[0, c] == '.') return false;
            return true;
        }

        public void Print()
        {
            Console.Clear();
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                    Console.Write(grid[r, c] + " ");
                Console.WriteLine();
            }
        }

        public char[,] GetGrid() => grid;
    }

}
