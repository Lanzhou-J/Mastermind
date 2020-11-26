namespace mastermind
{
    public class Player
    {
        public Player(string name, IGenerateSolution solutionGenerator)
        {
            Name = name;
            SolutionGenerator = solutionGenerator;
        }

        private IGenerateSolution SolutionGenerator; 

        public string Name { get; set; }
        

        public Peg[] GenerateSolution(Colour[] colours)
        {
            return SolutionGenerator.GenerateSolution(colours);
        }
    }
}