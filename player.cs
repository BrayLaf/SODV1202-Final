namespace Connect4_game
{
    public class Player {
        private string name;
        private char symbol;

        public string Name { get => name; set => name = value; }
        public char Symbol { get => symbol; set => symbol = value; }

        public Player(string name, char symbol) {
            Name = name;
            Symbol = symbol;
        }
    }
}
