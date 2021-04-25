using System;

namespace simonsays
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrOfInput = int.Parse(Console.ReadLine());
            for(int i = 0; i < nrOfInput; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                if(input[0] == "Simon" && input[1] == "says")
                {
                    for (int b = 2; b < input.Length; b++)
                    {
                        Console.Write($" {input[b]}");
                    }
                }
                else
                {
                    continue;
                }
                Console.WriteLine();
            }
        }

    }
}
