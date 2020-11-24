using System.Collections.Generic;
using mastermind;

namespace mastermindTests
{
    public class TestResponder: IInput
    {
        private readonly Queue <string>_testResponses = new Queue<string>();
        
        public TestResponder(IEnumerable<string> testResponse)
        {
            foreach (var response in testResponse)
            {
                _testResponses.Enqueue(response);
            }
        }
        public string Ask(string question)
        {
            var response = _testResponses.Dequeue();
            return response;
        }
    }
}