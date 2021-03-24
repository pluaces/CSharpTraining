using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguageFeatures.CSharpSeven
{

    // Local functions can help with code readability and also with
    // the protection level of a given method

    public class LocalFunctions
    {
        // Example: recursive method
        public static int LocalFunctionFactorial(int n)
        {
            return nthFactorial(n);

            int nthFactorial(int number) => number < 2 ? 1 : number * nthFactorial(number - 1);
        }


        public static int InternalVariables()
        {
            var x = 4;

            LocalFuntionAssign();

            //return x; // Returns 8

            return LocalFuntionDivide(); // Returns 4

            void LocalFuntionAssign()
            {
                x = 8;
            }

            int LocalFuntionDivide() => x / 2;
        }
    }
}
