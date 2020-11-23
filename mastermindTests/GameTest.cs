using mastermind;
using Xunit;

namespace mastermindTests
{
    public class GameTest
    {
        [Fact]
        public void SelectSecretSolutionShould_ReturnArrayOfPegs_WhenColoursAreSet()
        {
            var game = new Game();
            var secretSolution = game.SelectSecretSolution();
            
        }
    }
}