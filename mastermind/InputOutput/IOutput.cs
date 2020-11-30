namespace mastermind
{
    public interface IOutput
    {
        void Write(string message);

        void Write(Colour[] colours);
        
        void Write(KeyPeg[] keyPegs);
        
        void Write(Peg[] Pegs);
    }
}