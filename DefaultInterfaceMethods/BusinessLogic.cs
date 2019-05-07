using System;
using System.Collections.Generic;
using System.Data; // Candiate for Code Cleanup
using System.Linq;

namespace CSharpEightFeatures
{
    class BusinessLogic
    {
        private readonly IFormatter _formatter ;

        public BusinessLogic(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public IEnumerable<int> GetData()
        {
            // Candidate for "Convert a foreach loop to LINQ" refactoring
            foreach (var j in Enumerable.Range(0, 4))
            {
                yield return j;

            }
            yield break;
        }

        public void Process()
        {
            foreach (int i in GetData())
            {
                Console.WriteLine(_formatter.Format(i));
            }
        }
    }
}
