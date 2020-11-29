using System;
using System.Linq;

namespace mastermind
{
    public class Mastermind
    {
        public Peg[] SecretSolution { get; private set; }

        public Mastermind(IGenerateSolution solutionGenerator)
        {
            SolutionGenerator = solutionGenerator;
        }

        private IGenerateSolution SolutionGenerator { get; }

        public void SetSecretSolution(Colour[] colours)
        {
            SecretSolution = SolutionGenerator.GenerateSolution(colours);
        }
        

        public KeyPeg[] CreateHintBasedOnPlayerSolution(Peg[] solution)
        {
            var keyPeg1 = new KeyPeg(Value.Empty);
            var keyPeg2 = new KeyPeg(Value.Empty);
            var keyPeg3 = new KeyPeg(Value.Empty);
            var keyPeg4 = new KeyPeg(Value.Empty);
            var hint = new[] {keyPeg1, keyPeg2, keyPeg3, keyPeg4};
            
            if (solution == null) return hint;
            if (SecretSolution == null) return hint;

            for (int i = 0; i < solution.Length; i++)
            {
                if (solution[i].Colour == SecretSolution[i].Colour)
                {
                    hint[i].Value = Value.Black;
                }
                else
                {
                    foreach (var item in SecretSolution)
                    {
                        if (solution[i].Colour == item.Colour)
                        {
                            hint[i].Value = Value.White;
                        }
                    }
                }
            }
            return hint;
        }
    }
}