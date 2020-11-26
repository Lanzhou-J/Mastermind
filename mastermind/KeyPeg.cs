namespace mastermind
{
    public enum Value
    {
        Black,
        White,
        Empty
    }
    public class KeyPeg
    {
        public KeyPeg(Value value)
        {
            Value = value;
        }

        private Value Value { get; set; }
    }
}