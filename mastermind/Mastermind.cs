using System;

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
            var keyPeg1 = new KeyPeg(Value.Black);
            var keyPeg2 = new KeyPeg(Value.Black);
            var keyPeg3 = new KeyPeg(Value.Black);
            var keyPeg4 = new KeyPeg(Value.Black);
            var hint = new[] {keyPeg1, keyPeg2, keyPeg3, keyPeg4};
            return hint;
        }
    }
}