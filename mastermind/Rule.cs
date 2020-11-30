using System.Linq;

namespace mastermind
{
    public class Rule: IRule
    {

        public bool IsWinningCondition(KeyPeg[] hint)
        {
            return hint.All(item => item.Value == Value.Black);
        }
    }
}