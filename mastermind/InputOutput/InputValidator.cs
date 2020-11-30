using System;

namespace mastermind
{
    public class InputValidator: IValidateInput
    {
        public void ThrowExceptionWhenTriedTooManyTimes(int guessCount)
        {
            if (guessCount > 60)
            {
                throw new Exception(GameInstruction.TooMoreTriesMessage());
            }
        }

        public void ThrowExceptionWhenSelectedColourIsInvalid(int number, int coloursLength)
        {
            if (number < 0 || number > coloursLength)
            {
                throw new Exception(GameInstruction.InvalidColourMessage());
            }
        }

        public void ThrowExceptionWhenInputLengthIsNotFour(string selection)
        {
            if (selection.Length != 4)
            {
                throw new Exception(GameInstruction.InvalidInputLengthMessage());
            }
        }
    }
}