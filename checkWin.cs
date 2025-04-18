namespace Connect4_game
{
    public static class WinChecker
    {
        public static bool HasWon(char[,] grid, char symbol)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            for (int r = 0; r < rows; r++)
                for (int c = 0; c <= cols - 4; c++)
                    if (grid[r, c] == symbol && grid[r, c + 1] == symbol &&
                        grid[r, c + 2] == symbol && grid[r, c + 3] == symbol)
                        return true;

            for (int c = 0; c < cols; c++)
                for (int r = 0; r <= rows - 4; r++)
                    if (grid[r, c] == symbol && grid[r + 1, c] == symbol &&
                        grid[r + 2, c] == symbol && grid[r + 3, c] == symbol)
                        return true;

            for (int r = 3; r < rows; r++)
                for (int c = 0; c <= cols - 4; c++)
                    if (grid[r, c] == symbol && grid[r - 1, c + 1] == symbol &&
                        grid[r - 2, c + 2] == symbol && grid[r - 3, c + 3] == symbol)
                        return true;

            for (int r = 0; r <= rows - 4; r++)
                for (int c = 0; c <= cols - 4; c++)
                    if (grid[r, c] == symbol && grid[r + 1, c + 1] == symbol &&
                        grid[r + 2, c + 2] == symbol && grid[r + 3, c + 3] == symbol)
                        return true;

            return false;
        }
    }
}
