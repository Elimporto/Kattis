using System;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(stopWatch(input));
        }
        static string stopWatch(int timesStopwatchIsPressed)
        {
            string output = "";
            int total = 0;

            if(timesStopwatchIsPressed % 2 == 0)
            {
                for(int i = 2; i <=timesStopwatchIsPressed; i+=2)
                {
                    int temp1 = int.Parse(Console.ReadLine());
                    int temp2 = int.Parse(Console.ReadLine());
                    total += temp2 - temp1;
                }
                output = total.ToString();
            }
            else
            {
                output = "still running";
            }


            return output;

        }
    }
}
