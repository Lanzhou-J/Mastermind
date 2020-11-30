using System;
using System.Runtime.CompilerServices;

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

        private Peg[] _currentSolution;

        public Colour[] Colours { get; } =
            GetColours();

        private Player Player { get; set; }
        private Mastermind Mastermind { get; set; }
        private IInput Input { get; set; }
        private IOutput Output { get; set; }

        private static Colour[] GetColours()
        {
            return new[] {Colour.Red, Colour.Blue, Colour.Green, Colour.Orange, Colour.Purple, Colour.Yellow};
        }

        public void Start()
        {
            WelcomeUser();
            DisplayInputRule();
            Mastermind.SetSecretSolution(Colours);
        }
        
        private void DisplayAllowedColours()
        {
            Output.Write(Colours);
        }
        
        private void DisplayInputRule()
        {
            Output.Write(GameInstruction.DisplayInputRuleMessage());
        }
        
        private void WelcomeUser()
        {
            Output.Write(GameInstruction.WelcomePlayerMessage(Player.Name));
        }

        public void Play()
        {
            while (true)
            {
                Output.Write(" ");
                DisplayAllowedColours();
                var selectedColours = UserSelectColours();
                Output.Write(selectedColours);
                _currentSolution = Player.GenerateSolution(selectedColours);
                var shuffledHint = Mastermind.CreateShuffledHintBasedOnPlayerSolution(_currentSolution);
                Output.Write(shuffledHint);
            }
        }

        public Colour[] UserSelectColours()
        {
            var selection = CollectUserInput();
            var selectedColours = GetSelectedColours(selection);
            return selectedColours;
        }

        private Colour[] GetSelectedColours(string selection)
        {
            var selectedColours = new Colour[4];

            var index = 0;
            foreach (var character in selection)
            {
                int number = character - '0';
                selectedColours[index] = Colours[number - 1];
                index++;
            }

            return selectedColours;
        }

        private string CollectUserInput()
        {
            return Input.Ask("Your selection:");
        }
    }
}