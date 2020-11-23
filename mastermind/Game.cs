using System;

namespace mastermind
{
    public class Game
    {
        public Colour[] Colours { get; } =
            new Colour[] {Colour.Red, Colour.Blue, Colour.Green, Colour.Orange, Colour.Purple, Colour.Yellow};

        public Peg[] SelectSecretSolution()
        {
            return new Peg[4];
        }
    }
}