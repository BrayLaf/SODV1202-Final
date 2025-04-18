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

        public bool DropDisc(int colInput, char symbol)
        {
            int col = colInput - 1;

            if (col < 0 || col >= Cols) 
                return false;

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
        public bool IsColumnFull(int colInput) {
            int col = colInput - 1;
            if (col < 0 || col >= 7)
                return true;

            return grid[0, col] != '.';
        }
        public void Print()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;

            string horizontal = "╔═══╦═══╦═══╦═══╦═══╦═══╦═══╗";
            string middle = "╠═══╬═══╬═══╬═══╬═══╬═══╬═══╣";
            string bottom = "╚═══╩═══╩═══╩═══╩═══╩═══╩═══╝";

            Console.WriteLine(horizontal);

            for (int r = 0; r < Rows; r++)
            {
                Console.Write("║");
                for (int c = 0; c < Cols; c++)
                {
                    char symbol = grid[r, c];
                    if (symbol == 'X') Console.ForegroundColor = ConsoleColor.Red;
                    else if (symbol == 'O') Console.ForegroundColor = ConsoleColor.Yellow;
                    else Console.ForegroundColor = ConsoleColor.White;

                    Console.Write($" {symbol} ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("║");
                }

                Console.WriteLine();
                if (r < Rows - 1)
                    Console.WriteLine(middle);
            }

            Console.WriteLine(bottom);

            // Print column numbers
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ");
            for (int c = 1; c <= Cols; c++)
                Console.Write($" {c}  ");

            Console.WriteLine("\n");
            Console.ResetColor();
        }

        public char[,] GetGrid() => grid;
    }

}
