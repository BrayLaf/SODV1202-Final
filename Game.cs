using System.Net.Http.Headers;

namespace Connect4_game
{
    public class Game {
        private Board board;
        private Player[] players;
        private int currentPlayerIndex;

        public Game() {
            board = new Board();
            players = new Player[2];
            currentPlayerIndex = 0;

            SetupPlayers();
        }
        private void SetupPlayers() {
            Console.WriteLine("Enter name for player 1: ");
            string name1 = Console.ReadLine();
            players[0] = new Player (name1, 'X');

            Console.WriteLine("Enter name for player 2: ");
            string name2 = Console.ReadLine();
            players[1] = new Player(name2, 'O');
        }

        public void Start() {
            bool gameWon = false;
            bool gameTie = false;

            while (!gameWon && !gameTie) {
                board.Print();
                Player currentPlayer = players[currentPlayerIndex];

                Console.WriteLine($"{currentPlayer.Name}'s turn ({currentPlayer.Symbol})");
                Console.WriteLine("Choose a column (0-6): ");
                int column;

                //check valid input
                while(!int.TryParse(Console.ReadLine(), out column) || !board.DropDisc(column, currentPlayer.Symbol)) {
                    Console.WriteLine("Invalid column, Try again:");
                }

                gameWon = WinChecker.HasWon(board.GetGrid(), currentPlayer.Symbol);
                gameTie = board.IsFull();

                if (!gameWon) {
                    currentPlayerIndex = (currentPlayerIndex + 1) % 2;
                }
            }

            board.Print();

            if (gameWon) {
                Console.WriteLine($"{players[currentPlayerIndex].Name} Wins!");
            }
            else {
                Console.WriteLine("Its a draw!");
            }
        }
    }
}
