namespace mastermind
{
    public class Peg
    {
        public Peg(Colour colour)
        {
            Colour = colour;
        }

        public Colour Colour { get; private set; }
    }
}