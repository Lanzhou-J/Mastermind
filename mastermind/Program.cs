using System;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleInput = new ConsoleInput();
            var consoleOutput = new ConsoleOutput();
            var solutionGenerator = new NormalSolutionGenerator();
            var player = new Player("Lan", solutionGenerator);
            var secretSolutionGenerator = new SecretSolutionGenerator();
            var mastermind = new Mastermind(secretSolutionGenerator);
            var rule = new Rule();
            var game = new Game(player, mastermind, consoleInput, consoleOutput, rule);
            try
            {
                game.Start();
                game.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }
    }
}