namespace mastermind
{
    public static class GameInstruction
    {
        public static string WelcomePlayerMessage(string name)
        {
            return $"Welcome to Mastermind, {name}!";
        }
        
        public static string DisplayInputRuleMessage()
        {
            return "Please select 4 colours (index) from the colours below to pick and place your pegs in a row (colours can be duplicated):";
        }
        
        public static string YouWonMessage()
        {
            return "You won!";
        }
        
        public static string YourSelectionMessage()
        {
            return "Your selection:";
        }
        
        public static string InvalidColourMessage()
        {
            return "you have given an invalid colour!";
        }
        
        public static string InvalidInputLengthMessage()
        {
            return "you must pass 4 colours!";
        }
        
        public static string TooMoreTriesMessage()
        {
            return "you have more than 60 tries!";
        }
        
        
    }
}