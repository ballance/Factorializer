using System;

namespace Ballance.IT
{
    public class Factorializer
    {
        private static void Main()
        {
            var firstInput = Console.ReadLine();

            // Handling as Int64 due to limitation of Int32.Max of 2,147,483,647
            UInt64 firstInteger = 1;
            if (!UInt64.TryParse(firstInput, out firstInteger))
            {
                Console.WriteLine("ERROR");
                return;
            }

            UInt64 factorialized = 1;

            for (UInt64 i = firstInteger; i > 0; i--)
            {
                factorialized *= i;
            }


            Console.WriteLine(factorialized);

            var secondInput = Console.ReadLine();

            UInt64 secondInteger = 0;
            if (!UInt64.TryParse(secondInput, out secondInteger))
            {
                Console.WriteLine("ERROR");
                return;
            }

            Console.WriteLine(factorialized == secondInteger ? "TRUE" : "FALSE");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
