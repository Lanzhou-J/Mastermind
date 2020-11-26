using mastermind;
using Xunit;

namespace mastermindTests
{
    public class GameTest
    {
        [Fact]
        public void GetSelectedColourShould_GetCorrectColours_WhenUserInputNumbers()
        {
            var testInput = new TestResponder(new[]{"1111"});
            var output = new ConsoleOutput();
            var player = new Player("Lan");
            var secretSolutionGenerator = new SecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            var game = new Game(player, mastermind, testInput, output);

            var expectedResult = new Colour[] {Colour.Red, Colour.Red, Colour.Red, Colour.Red};
            var actualResult = game.UserSelectColours();
            Assert.Equal(expectedResult, actualResult);
        }
    }
}