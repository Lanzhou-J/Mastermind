using mastermind;
using Xunit;

namespace mastermindTests
{
    public class RuleTest
    {
        [Fact]
        public void IsWinningConditionShould_returnTrue_WhenHintIsAllBlack()
        {
            var rule = new Rule();
            var keyPeg1 = new KeyPeg(Value.Black);
            var keyPeg2 = new KeyPeg(Value.Black);
            var keyPeg3 = new KeyPeg(Value.Black);
            var keyPeg4 = new KeyPeg(Value.Black);
            var hint = new[] {keyPeg1, keyPeg2, keyPeg3, keyPeg4};
            var result = rule.IsWinningCondition(hint);
            Assert.True(result);
        }
        
        [Fact]
        public void IsWinningConditionShould_returnFalse_WhenHintHasOneEmpty()
        {
            var rule = new Rule();
            var keyPeg1 = new KeyPeg(Value.Empty);
            var keyPeg2 = new KeyPeg(Value.Black);
            var keyPeg3 = new KeyPeg(Value.Black);
            var keyPeg4 = new KeyPeg(Value.Black);
            var hint = new[] {keyPeg1, keyPeg2, keyPeg3, keyPeg4};
            var result = rule.IsWinningCondition(hint);
            Assert.False(result);
        }
    }


}