using System;
using System.Collections.Generic;
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

        public KeyPeg[] CreateShuffledHintBasedOnPlayerSolution(Peg[] solution)
        {
            var hint = CreateHintBasedOnPlayerSolution(solution);
            var shuffledHint = GenerateShuffledHint(hint);
            return shuffledHint;
        }

        private KeyPeg[] GenerateShuffledHint(KeyPeg[] hint)
        {
            Random rnd = new Random();
            var shuffledHint = hint.OrderBy(x => rnd.Next()).ToArray();
            return shuffledHint;
        }

        public KeyPeg[] CreateHintBasedOnPlayerSolution(Peg[] solution)
        {
            var hint = CreateHintWith4EmptyKeyPegs();

            if (solution == null) return hint;
            if (SecretSolution == null) return hint;

            SetEachKeyPegValueInHint(solution, hint);
            return hint;
        }

        private void SetEachKeyPegValueInHint(Peg[] solution, KeyPeg[] hint)
        {
            var flagList = new List<int>();

            SetBlackKeyPegs(solution, hint, flagList);
            SetWhiteKeyPegs(solution, hint, flagList);
        }

        private void SetWhiteKeyPegs(Peg[] solution, KeyPeg[] hint, List<int> flagList)
        {
            for (var i = 0; i < solution.Length; i++)
            {
                if (flagList.Contains(i)) continue;
                for (var j = 0; j < SecretSolution.Length; j++)
                {
                    if (flagList.Contains(j)) continue;
                    if (solution[i].Colour == SecretSolution[j].Colour)
                    {
                        hint[i].Value = Value.White;
                    }
                }
            }
        }

        private void SetBlackKeyPegs(Peg[] solution, KeyPeg[] hint, List<int> flagList)
        {
            for (var i = 0; i < solution.Length; i++)
            {
                if (solution[i].Colour != SecretSolution[i].Colour) continue;
                hint[i].Value = Value.Black;
                flagList.Add(i);
            }
        }

        private static KeyPeg[] CreateHintWith4EmptyKeyPegs()
        {
            var keyPeg1 = new KeyPeg(Value.Empty);
            var keyPeg2 = new KeyPeg(Value.Empty);
            var keyPeg3 = new KeyPeg(Value.Empty);
            var keyPeg4 = new KeyPeg(Value.Empty);
            var hint = new[] {keyPeg1, keyPeg2, keyPeg3, keyPeg4};
            return hint;
        }
    }
}