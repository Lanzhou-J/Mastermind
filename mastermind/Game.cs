using System;

namespace mastermind
{
    public class Game
    {
        public Colour[] Colours { get; } =
            new Colour[] {Colour.Red, Colour.Blue, Colour.Green, Colour.Orange, Colour.Purple, Colour.Yellow};

        public Peg[] SelectSecretSolution()
        {
            var secretSolution = new Peg[4];
            for (int i = 0; i < 4; i++)
            {
                var rand = new Random();
                var randNumber = rand.Next(Colours.Length);
                secretSolution[i] = new Peg(Colours[randNumber]);
            }

            return secretSolution;
        }
    }
}