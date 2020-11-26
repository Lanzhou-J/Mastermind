using System;

namespace mastermind
{
    public class SecretSolutionGenerator : IGenerateSolution
    {
        public Peg[] GenerateSolution(Colour[] colours)
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
    }
}