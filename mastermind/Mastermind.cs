using System;

namespace mastermind
{
    public class Mastermind
    {
        public Peg[] SelectSecretSolution(Colour[] colours)
        {
            var secretSolution = new Peg[4];
            for (int i = 0; i < 4; i++)
            {
                var rand = new Random();
                var randNumber = rand.Next(colours.Length);
                secretSolution[i] = new Peg(colours[randNumber]);
            }

            return secretSolution;
        }

        public KeyPeg[] CreateHintBasedOnPlayerSolution(Peg[] solution)
        {
            return new KeyPeg[4];
        }
    }
}