namespace mastermind
{
    public interface IOutput
    {
        void Write(string message);

        void Write(Colour[] colours);
    }
}