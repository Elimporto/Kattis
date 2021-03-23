using System;

namespace oddities
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int testCases);
            for (int i = 0; i < testCases; i++)
            {
                int.TryParse(Console.ReadLine(), out int input);
                Console.WriteLine(isItEvenOrOdd(input));
            }

        }

        static string isItEvenOrOdd(int input)
        {
            string output = "";
            if (input % 2 == 0)
            {
                output = $"{input} is even";
            }
            else
            {
                output = $"{input} is odd";
            }

            return output;
        }

    }
}
