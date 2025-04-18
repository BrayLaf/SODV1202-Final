using System;

namespace Connect4_game
{
    class Program
    {
        static void Main()
        {
            var board = new Board();
            var player1 = new Player("Player 1", 'X');
            var player2 = new Player("Player 2", 'O');
            var currentPlayer = player1;

            while (true)
            {
                board.Print();
                Console.WriteLine($"\n{currentPlayer.Name} ({currentPlayer.Symbol}), choose column (0–6):");

                if (int.TryParse(Console.ReadLine(), out int col) && col >= 0 && col < 7)
                {
                    if (!board.DropDisc(col, currentPlayer.Symbol))
                    {
                        Console.WriteLine("Column full. Try again.");
                        continue;
                    }

                    if (WinChecker.HasWon(board.GetGrid(), currentPlayer.Symbol))
                    {
                        board.Print();
                        Console.WriteLine($"\n{currentPlayer.Name} wins!");
                        break;
                    }

                    if (board.IsFull())
                    {
                        board.Print();
                        Console.WriteLine("\nIt's a tie!");
                        break;
                    }

                    currentPlayer = currentPlayer == player1 ? player2 : player1;
                }
                else
                {
                    Console.WriteLine("Invalid column. Try again.");
                }
            }
        }
    }
}
