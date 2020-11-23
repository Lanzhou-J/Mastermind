using System.Linq;
using mastermind;
using Xunit;

namespace mastermindTests
{
    public class GameTest
    {
        [Fact]
        public void SelectSecretSolutionShould_ReturnArrayOf4Pegs()
        {
            var game = new Game();
            var secretSolution = game.SelectSecretSolution();
            
            Assert.Equal(4, secretSolution.Length);
        }
        
        [Fact]
        public void SelectSecretSolutionShould_ReturnArrayOf4Pegs_WithCorrectColour()
        {
            var game = new Game();
            var secretSolution = game.SelectSecretSolution();

            foreach (var peg in secretSolution)
            {
                Assert.Contains(peg.Colour, game.Colours);
            }
        }
    }
}