using System;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleInput = new ConsoleInput();
            var consoleOutput = new ConsoleOutput();
            var player = new Player("Lan");
            var secretSolutionGenerator = new SecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            var game = new Game(player, mastermind, consoleInput, consoleOutput);
            
            game.Start();
            game.Play();
        }
    }
}