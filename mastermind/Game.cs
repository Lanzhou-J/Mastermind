using System;

namespace mastermind
{
    public class Game
    {
        public Game(Player player, Mastermind mastermind, IInput input, IOutput output)
        {
            Player = player;
            Mastermind = mastermind;
            Input = input;
            Output = output;
        }

        public Colour[] Colours { get; } =
            GetColours();

        private Player Player { get; set; }
        private Mastermind Mastermind { get; set; }
        private IInput Input { get; set; }
        private IOutput Output { get; set; }

        private static Colour[] GetColours()
        {
            return new Colour[] {Colour.Red, Colour.Blue, Colour.Green, Colour.Orange, Colour.Purple, Colour.Yellow};
        }

        // private Colour[] CollectUserInput()
        // {
        //
        // }

        public void Start()
        {
            WelcomeUser();
        }

        private void WelcomeUser()
        {
            Output.Output($"Welcome to Mastermind, {Player.Name}!");
        }
    }
}