using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hej på dig din lilla horunge";
            string[] str = input.Split(" ");
            string result = "";
            int max = 0;
            foreach (string word in str)
            {
                if(word.Length > max)
                {
                    max = word.Length;
                    result = word;
                }
            }
            string[,] output = new string[str.Length,result.Length+4];
            for(int i = -1; i < str.Length+1; i++)
            {
                if (i >= 0 && i < str.Length)
                {
                    decimal spacingFront = (result.Length+1)-str[i].Length;
                    Console.Write("*");
                    for(int space =0; space < spacingFront; space++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(str[i]);

                    Console.Write(" *");
                }
                else
                {
                    if (i == -1 || i == str.Length)
                    {
                       for (int row = 0; row < result.Length +4; row++)
                        {
                            Console.Write("*");
                        }
                    }
                }


                Console.WriteLine(" ");
            }
        }
    }
}
