using mastermind;
using Xunit;

namespace mastermindTests
{
    public class PlayerTest
    {
        [Fact]
        public void GenerateSolutionShould_GeneratePegsBasedOnColours()
        {
            var solutionGenerator = new NormalSolutionGenerator();
            Player player = new Player(name:"Lan", solutionGenerator);
            Colour[] colours = new[] {Colour.Blue, Colour.Red, Colour.Blue, Colour.Red};
            var actualResult = player.GenerateSolution(colours);

            for (int i = 0; i < actualResult.Length; i++)
            {
                Assert.Equal(colours[i], actualResult[i].Colour);
            }
            
        }
    }
}