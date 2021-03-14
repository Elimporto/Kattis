using System;

namespace greetings2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(greetDoubleE(countNrOfEs(Console.ReadLine())));
        }

        static int countNrOfEs(string input)
        {
            int amountOfEs = 0;
            foreach (char letter in input)
            {
                if (letter != 'e')
                {
                    continue;
                }

                amountOfEs++;

            }

            return amountOfEs;
        }

        static string greetDoubleE(int input)
        {
            string e = "";
            input *= 2;
            for (int i = 0; i < input; i++)
            {
                e += "e";
            }

            string hey = $"h{e}y";
            return hey;
        }
    }
}
