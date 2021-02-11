using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int howManyInputs);

            int exponent = 0;
            long sum = 0;
            string input = "";
            for (int i = 0; i < howManyInputs; i++)
            {
                input = Console.ReadLine();
                int.TryParse(input[input.Length - 1].ToString(), out exponent);
                input = input.Remove(input.Length - 1);
                int.TryParse(input, out int number);
                if (exponent == 0)
                {
                    sum += 1;
                }
                else
                    sum += Power(number, exponent);
            }
            Console.WriteLine(sum);

        }
        static int Power(int number, int power)
        {
            int newNumber = number;
            for (int i = power; i > 1; i--)
            {
                newNumber *= number;
            }
            return newNumber;
        }

    }
}
