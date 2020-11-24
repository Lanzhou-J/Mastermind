using System.Linq;
using mastermind;
using Xunit;
using Moq;

namespace mastermindTests
{
    public class GameTest
    {
        [Fact]
        public void StartShould_WelcomePlayer()
        {
            var mockConsoleInput = new Mock<IInput>();
            var mockConsoleOutput = new Mock<IOutput>();
            var player = new Player("Lan");
            var mastermind = new Mastermind();
            var game = new Game(player, mastermind, mockConsoleInput.Object, mockConsoleOutput.Object);
            
            game.Start();
            mockConsoleOutput.Verify(x=> x.Write("Welcome to Mastermind, Lan!"), Times.Exactly(1));
        }
        
        [Fact]
        public void StartShould_DisplayAllowedColours()
        {
            var mockConsoleInput = new Mock<IInput>();
            var mockConsoleOutput = new Mock<IOutput>();
            var player = new Player("Lan");
            var mastermind = new Mastermind();
            var game = new Game(player, mastermind, mockConsoleInput.Object, mockConsoleOutput.Object);
            
            game.Start();
            mockConsoleOutput.Verify(x=> x.Write(game.Colours), Times.Exactly(1));
        }
    }
}