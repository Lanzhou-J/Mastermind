namespace mastermind
{
    public interface IGenerateSolution
    {
        Peg[] GenerateSolution(Colour[] colours);
    }
}