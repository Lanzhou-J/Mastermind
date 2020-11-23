using System;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var colours = game.Colours;
            foreach (var item in colours)
            {
                Console.WriteLine(item);
            }
        }
    }
}