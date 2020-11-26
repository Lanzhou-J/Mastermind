namespace mastermind
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        

        public Peg[] GenerateSolution(Colour[] colours)
        {
            var solution = new Peg[4];
            for (int i = 0; i < 4; i++)
            {
                solution[i] = new Peg(colours[i]);
            }

            return solution;
        }
    }
}