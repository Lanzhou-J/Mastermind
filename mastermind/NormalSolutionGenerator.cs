namespace mastermind
{
    public class NormalSolutionGenerator : IGenerateSolution
    {
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