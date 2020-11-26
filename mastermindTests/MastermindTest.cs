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
            var secretSolutionGenerator = new SecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            mastermind.SetSecretSolution(_colours);
            
            Assert.Equal(4, mastermind.SecretSolution.Length);
        }
        
        [Fact]
        public void SelectSecretSolutionShould_ReturnArrayOf4Pegs_WithCorrectColour()
        {
            var secretSolutionGenerator = new SecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            mastermind.SetSecretSolution(_colours);

            foreach (var peg in mastermind.SecretSolution)
            {
                Assert.Contains(peg.Colour, _colours);
            }
        }

        [Fact]
        public void CreateHintBasedOnPlayerSolutionShould_CreateHintWith4KeyPegs_BasedOnPlayerSolution()
        {
            var secretSolutionGenerator = new SecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            var peg1 = new Peg(Colour.Red);
            var peg2 = new Peg(Colour.Blue);
            var peg3 = new Peg(Colour.Green);
            var peg4 = new Peg(Colour.Orange);
            var solution = new[] {peg1, peg2, peg3, peg4};
            var hint = mastermind.CreateHintBasedOnPlayerSolution(solution);
            
            Assert.Equal(4, hint.Length);
        }
        
        [Fact]
        public void CreateHintBasedOnPlayerSolutionShould_CreateCorrectHint_BasedOnPlayerSolution()
        {
            var secretSolutionGenerator = new MockSecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            var peg1 = new Peg(Colour.Red);
            var peg2 = new Peg(Colour.Blue);
            var peg3 = new Peg(Colour.Green);
            var peg4 = new Peg(Colour.Orange);
            var solution = new[] {peg1, peg2, peg3, peg4};
            var hint = mastermind.CreateHintBasedOnPlayerSolution(solution);

            foreach (var item in hint)
            {
                Assert.Equal(Value.Black, item.Value);
            }
        }
        
        // [Fact]
        // public void CreateHintBasedOnPlayerSolutionShould_CreateCorrectHintWithAllEmptyValues_BasedOnPlayerSolution()
        // {
        //     var secretSolutionGenerator = new MockSecretSolutionGenerator();
        //     var mastermind = new Mastermind(secretSolutionGenerator);
        //     var peg1 = new Peg(Colour.Yellow);
        //     var peg2 = new Peg(Colour.Yellow);
        //     var peg3 = new Peg(Colour.Yellow);
        //     var peg4 = new Peg(Colour.Yellow);
        //     var solution = new[] {peg1, peg2, peg3, peg4};
        //     var hint = mastermind.CreateHintBasedOnPlayerSolution(solution);
        //
        //     foreach (var item in hint)
        //     {
        //         Assert.Equal(Value.Empty, item.Value);
        //     }
        // }
    }
}