using System;

namespace mastermind
{
    public class Game
    {
        public Game()
        {
        }

        public Colour[] Colours { get; } =
            GetColours();

        private static Colour[] GetColours()
        {
            return new Colour[] {Colour.Red, Colour.Blue, Colour.Green, Colour.Orange, Colour.Purple, Colour.Yellow};
        }

        

  
    }
}