using System.Linq;

namespace mastermind
{
    public static class Rule
    {
        public static bool IsWinningCondition(KeyPeg[] hint)
        {
            return hint.All(item => item.Value == Value.Black);
        }
    }
}