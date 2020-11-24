namespace mastermind
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        private string Name { get; set; }
        

        public Peg[] GenerateSolution(Colour[] colours)
        {
            return new Peg[4];
        }
    }
}