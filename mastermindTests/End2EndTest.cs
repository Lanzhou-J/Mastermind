using System;
using mastermind;
using Xunit;

namespace mastermindTests
{
    public class End2EndTest
    {
        [Fact]
        public void PlayShould_SetPlayerIsWinnerTrue_WhenSolutionIsCorrect()
        {
            var testInput = new TestResponder(new[]{"1111", "2222", "1234"});
            var output = new ConsoleOutput();
            var solutionGenerator = new NormalSolutionGenerator();
            var player = new Player("Lan", solutionGenerator);
            var secretSolutionGenerator = new MockSecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            var rule = new Rule();
            var game = new Game(player, mastermind, testInput, output, rule);
            
            game.Start();
            game.Play();
            Assert.True(player.IsWinner);
            Assert.Equal(3, game.GuessCount);
        }
        
        [Fact]
        public void PlayShould_ThrowException_WhenInvalidColourIsSelected()
        {
            var testInput = new TestResponder(new[]{"1117", "2222", "1234"});
            var output = new ConsoleOutput();
            var solutionGenerator = new NormalSolutionGenerator();
            var player = new Player("Lan", solutionGenerator);
            var secretSolutionGenerator = new MockSecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            var rule = new Rule();
            var game = new Game(player, mastermind, testInput, output, rule);
            
            game.Start();
            var ex = Assert.Throws<Exception>(() => game.Play());
            Assert.Equal("you have given an invalid colour!", ex.Message);
        }
        
        [Fact]
        public void PlayShould_ThrowException_WhenInputLengthIsInvalid()
        {
            var testInput = new TestResponder(new[]{"111", "2222", "1234"});
            var output = new ConsoleOutput();
            var solutionGenerator = new NormalSolutionGenerator();
            var player = new Player("Lan", solutionGenerator);
            var secretSolutionGenerator = new MockSecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            var rule = new Rule();
            var game = new Game(player, mastermind, testInput, output, rule);
            
            game.Start();
            var ex = Assert.Throws<Exception>(() => game.Play());
            Assert.Equal("you must pass 4 colours!", ex.Message);
        }
        
        [Fact]
        public void PlayShould_ThrowException_WhenTooManyTries()
        {
            var input = new string[61];
            for (int i = 0; i < 61; i++)
            {
                input[i] = "1111";
            }
            Assert.Equal(61, input.Length);
            var testInput = new TestResponder(input);
            var output = new ConsoleOutput();
            var solutionGenerator = new NormalSolutionGenerator();
            var player = new Player("Lan", solutionGenerator);
            var secretSolutionGenerator = new MockSecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            var rule = new Rule();
            var game = new Game(player, mastermind, testInput, output, rule);
            
            game.Start();
            var ex = Assert.Throws<Exception>(() => game.Play());
            Assert.Equal("you have more than 60 tries!", ex.Message);
        }
        
    }
}