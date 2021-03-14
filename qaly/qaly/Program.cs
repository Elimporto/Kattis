using System;
using System.Windows.Markup;

namespace qaly
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int numberOfInputs);
            string[] input = new string[numberOfInputs];
            
            for (int i = 0; i < numberOfInputs; i++)
            {
                input[i] = Console.ReadLine();
            }
            Console.WriteLine(QALI(input));
        }

        static double QALI(string[] input)
        {
            double qali = 0;
            foreach (var line in input)
            {
                string[] tempStringHolder = line.Split(' ');
                double.TryParse(tempStringHolder[0], out double qaliPeriod);
                double.TryParse(tempStringHolder[1], out double qaliYearPeriod);
                qali += (qaliPeriod * qaliYearPeriod);
            }

            return qali;
        }
    }
}
