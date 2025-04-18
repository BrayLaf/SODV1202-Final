namespace Connect4_game {
    public class AIPlayer : Player {
        private Random random;

        public AIPlayer(string name, char symbol) : base(name, symbol) {
            random = new Random();
        }

        public int ChooseColumn(Board board) {
            var grid = board.GetGrid();
            int cols = grid.GetLength(1);
            List<int> validColumns = new List<int>();

            for (int c = 1; c <= cols; c++) // Note: your Board.DropDisc expects 1-based columns
            {
                if (!board.IsColumnFull(c)) {
                    validColumns.Add(c);
                }
            }

            return validColumns[random.Next(validColumns.Count)];
        }
    }
}