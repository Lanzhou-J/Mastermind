using System;

namespace mastermind
{
    public class ConsoleInput: IInput
    {
        public string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}