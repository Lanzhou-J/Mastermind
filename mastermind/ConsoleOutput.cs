using System;

namespace mastermind
{
    public class ConsoleOutput: IOutput
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public void Write(Colour[] colours)
        {
            var index = 1;
            foreach (var item in colours)
            {
                Console.WriteLine(index+" "+item);
                index++;
            }
        }
    }
}