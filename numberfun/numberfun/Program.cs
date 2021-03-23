using System;

namespace numberfun
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int testCases);
            for (int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                Console.WriteLine(IsItPossible(input));
            }
            
        }

        static string IsItPossible(string input)
        {
            
                string[] holder = input.Split(" ");
                decimal.TryParse(holder[0], out decimal a);
                decimal.TryParse(holder[1], out decimal b);
                decimal.TryParse(holder[2], out decimal c);
                if (a + b == c)
                {
                   return "Possible";
                }
                else if (a - b == c)
                {
                    return "Possible";
                }
                else if (a * b == c)
                {
                    return "Possible";
                }
                else if (a / b == c)
                {
                    return "Possible";
                }
                else if (b-a == c)
                {
                    return "Possible";
                }
                else if (b / a == c)
                {
                    return "Possible";
                }
                else
                {
                   return "Impossible";
                }
        }

    }
}
