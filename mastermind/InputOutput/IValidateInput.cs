namespace mastermind
{
    public interface IValidateInput
    {
        void ThrowExceptionWhenTriedTooManyTimes(int guessCount);
        
        void ThrowExceptionWhenSelectedColourIsInvalid(int number, int coloursLength);
        
        void ThrowExceptionWhenInputLengthIsNotFour(string selection);
    }
}