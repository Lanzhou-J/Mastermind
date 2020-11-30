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
                Console.Write(index+"."+item + " ");
                index++;
            }
            Console.WriteLine();
        }

        public void Write(KeyPeg[] keyPegs)
        {
            foreach (var item in keyPegs)
            {
                Console.Write( item.Value + "  ");
            }
            Console.WriteLine();
        }
        
        public void Write(Peg[] pegs)
        {
            foreach (var item in pegs)
            {
                Console.Write( item.Colour + "  ");
            }
            Console.WriteLine();
        }
    }
}