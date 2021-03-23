using System;
using System.Reflection.Metadata;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int[] aInt = stringScore(a);
            int aScore = countScores(aInt);
            string b = Console.ReadLine();
            int[] bInt = stringScore(b);
            int bScore = countScores(bInt);
            string c = Console.ReadLine();
            int[] cInt = stringScore(c);
            int cScore = countScores(cInt);
            string d = Console.ReadLine();
            int[] dInt = stringScore(d);
            int dScore = countScores(dInt);
            string e = Console.ReadLine();
            int[] eInt = stringScore(e);
            int eScore = countScores(eInt);
            Console.WriteLine(winner(aScore, bScore, cScore, dScore,eScore));
        }

        static int[] stringScore(string input)
        {
            string[] tempHolder = input.Split(" ");
            int[] scores = new int[5];
            for (int i = 0; i < tempHolder.Length; i++)
            {
                int.TryParse(tempHolder[i], out scores[i]);
            }

            return scores;
        }

        static int countScores(int[] input)
        {
            int holder = 0;
            foreach (var VARIABLE in input)
            {
                holder += VARIABLE;
            }

            return holder;
        }

        static string winner(int a, int b, int c, int d, int e)
        {
            string output = "";
            int f = Math.Max(a, Math.Max(b, (Math.Max(c, Math.Max(d, e)))));
            if (f == a)
            {
                output = $"1 {f}";
            }
            if (f == b)
            {
                output = $"2 {f}";
            }
            if (f == c)
            {
                output = $"3 {f}";
            }
            if (f == d)
            {
                output = $"4 {f}";
            }
            if (f == e)
            {
                output = $"5 {f}";
            }
            return output;
        }
        

        
    }
}
