using mastermind;
using Xunit;

namespace mastermindTests
{
    public class MastermindTest
    {
        private readonly Colour[] _colours = new Colour[] {Colour.Red, Colour.Blue, Colour.Green, Colour.Orange, Colour.Purple, Colour.Yellow};
        [Fact]
        public void SelectSecretSolutionShould_ReturnArrayOf4Pegs()
        {
            var mastermind = new Mastermind();
            var secretSolution = mastermind.SelectSecretSolution(_colours);
            
            Assert.Equal(4, secretSolution.Length);
        }
        
        [Fact]
        public void SelectSecretSolutionShould_ReturnArrayOf4Pegs_WithCorrectColour()
        {
            var mastermind = new Mastermind();
            var secretSolution = mastermind.SelectSecretSolution(_colours);

            foreach (var peg in secretSolution)
            {
                Assert.Contains(peg.Colour, _colours);
            }
        }

        [Fact]
        public void CreateHintBasedOnPlayerSolutionShould_CreateHintWith4KeyPegs_BasedOnPlayerSolution()
        {
            var mastermind = new Mastermind();
            var peg1 = new Peg(Colour.Red);
            var peg2 = new Peg(Colour.Blue);
            var peg3 = new Peg(Colour.Green);
            var peg4 = new Peg(Colour.Orange);
            var solution = new[] {peg1, peg2, peg3, peg4};
            var hint = mastermind.CreateHintBasedOnPlayerSolution(solution)
        }
    }
}