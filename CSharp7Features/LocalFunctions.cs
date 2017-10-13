using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Features
{
    class LocalFunctions
    {
        public void SimpleLocalMethod()
        {
            int z = 0;
            z = Sum(1, 2);

            int Sum(int x, int y, params object[] p)
            {
                return x + y;
            }
        }

        // More realistic local method
        // no one can call longRunningWorkImplementation() without validating the arguments
        public Task<string> PerformLongRunningWork(string address, int index, string name)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException(message: "An address is required", paramName: nameof(address));
            if (index < 0)
                throw new ArgumentOutOfRangeException(paramName: nameof(index), message: "The index must be non-negative");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(message: "You must supply a name", paramName: nameof(name));

            return longRunningWorkImplementation();

            async Task<string> longRunningWorkImplementation()
            {
                var interimResult = await FirstWork(address);
                var secondResult = await SecondStep(index, name);
                return $"The results are {interimResult} and {secondResult}. Enjoy.";
            }

            Task<string> FirstWork(string stepAddress) { return Task.FromResult(""); }

            Task<string> SecondStep(int stepIndex, string stepName) { return Task.FromResult(""); }
       }

    }
}
