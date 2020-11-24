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
    }
}