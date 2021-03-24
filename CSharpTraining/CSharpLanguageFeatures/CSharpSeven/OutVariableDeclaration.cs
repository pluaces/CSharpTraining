using System;

namespace CSharpLanguageFeatures.CSharpSeven
{
    public class OutVariableDeclaration
    {
        public int Foo()
        {
            var stringNumber = "1234";

            // Before C#7

            int number;

            if (int.TryParse(stringNumber, out number))
            {
                Console.WriteLine(number);

                return number;
            }

            // Now you can do this
            if (int.TryParse(stringNumber, out int myNumber))
            {
                Console.WriteLine(myNumber);

                return myNumber;
            }

            // Or even use var like this
            if (int.TryParse(stringNumber, out var myVarNumber))
            {
                Console.WriteLine(myVarNumber);

                return myVarNumber;
            }

            return 0;
        }
    }
}
