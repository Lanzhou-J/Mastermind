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
    }
}