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
            return new[] {Colour.Red, Colour.Blue, Colour.Green, Colour.Orange, Colour.Purple, Colour.Yellow};
        }

        public void Start()
        {
            WelcomeUser();
            DisplayInputRule();
            DisplayAllowedColours();
        }

        public void Play()
        {
            var selection = CollectUserInput();
            var selectedColours = GetSelectedColours(selection);
            Output.Write(selectedColours);
            Player.GenerateSolution(selectedColours);
        }

        public Colour[] GetSelectedColours(string selection)
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
    }
}