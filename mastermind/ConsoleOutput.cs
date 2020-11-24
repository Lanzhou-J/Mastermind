using System;

namespace mastermind
{
    public class ConsoleOutput: IOutput
    {
        public void Output(string message)
        {
            Console.WriteLine(message);
        }
    }
}