using System;

namespace Cold_puter_Science
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int temperaturesCollected);
            string[] temperatures = Console.ReadLine().Split(" ");
            Console.WriteLine(HowManyTempsAreUnderZero(temperatures));
        }
        static int HowManyTempsAreUnderZero(string[] temperatures)
        {
            int numberOfTemperaturesUnderZero = 0;
            for(int i = 0; i < temperatures.Length; i++)
            {
            int.TryParse(temperatures[i], out int temperature);
                if (temperature < 0)
                {
                    numberOfTemperaturesUnderZero++;
                }
            }
            return numberOfTemperaturesUnderZero;
        }
    }
}
