using mastermind;

namespace mastermindTests
{
    public class MockSecretSolutionGenerator : IGenerateSolution
    {
        public Peg[] GenerateSolution(Colour[] colours)
        {
            var peg1 = new Peg(Colour.Red);
            var peg2 = new Peg(Colour.Blue);
            var peg3 = new Peg(Colour.Green);
            var peg4 = new Peg(Colour.Orange);
            var solution = new[] {peg1, peg2, peg3, peg4};

            return solution;
        }
    }
}