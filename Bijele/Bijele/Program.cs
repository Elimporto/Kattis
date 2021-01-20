using System;

namespace Bijele
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * King: 1
             * Queen: 1
             * Rooks: 2
             * Bishops: 2
             * Knights: 2
             * Pawns: 8
             */

            int[] comparable = { 1, 1, 2, 2, 2, 8 };
            string input = Console.ReadLine();
            string[]arr =input.Split(" ");
            string output = "";
            for(int i=0; i < arr.Length; i++)
            {
                int diff = 0;
                int temp = int.Parse(arr[i].ToString());
                if (i < arr.Length - 1)
                {
                    if (temp == comparable[i])
                    {
                        output +="0 ";
                    }
                    else if (temp != comparable[i])
                    {
                        while (temp > comparable[i])
                        {
                            temp--;
                            diff--;
                        }
                        while (temp < comparable[i])
                        {
                            temp++;
                            diff++;
                        }
                        output += diff + " ";
                    }
                }
                else
                {
                    if (temp == comparable[i])
                    {
                        output += "0";
                    }
                    else if (temp != comparable[i])
                    {
                        while (temp > comparable[i])
                        {
                            temp--;
                            diff--;
                        }
                        while (temp < comparable[i])
                        {
                            temp++;
                            diff++;
                        }
                        output += diff;
                    }
                }

            }
            Console.WriteLine(output);
        }

    }
}
