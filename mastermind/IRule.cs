namespace mastermind
{
    public interface IRule
    {
        public bool IsWinningCondition(KeyPeg[] hint);
    }
}