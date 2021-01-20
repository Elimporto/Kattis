using System;

namespace GrassSeedInc
{
    class Program
    {
        static void Main(string[] args)
        {
            float price = float.Parse(Console.ReadLine());
            int nrOfLawns = int.Parse(Console.ReadLine());
            float totalSqrm = 0;
            int n = 0;
            while (n < nrOfLawns)
            {
                bool firstcont = true;
                string n1 = "";
                string n2 = "";
                string str = Console.ReadLine();
                for(int i = 0; i < str.Length; i++)
                {
                    if(str[i]!=' ' && firstcont == true)
                    {
                        n1 += str[i];
                        continue;
                    }
                    else if(str[i]==' ')
                    {
                        firstcont = false;
                        i++;
                    }
                    if (firstcont == false)
                    {
                        n2 += str[i];
                    }
                }
                float nr1 = float.Parse(n1);
                float nr2 = float.Parse(n2);
                totalSqrm += nr1 * nr2;
                n++;
            }
            Console.WriteLine(totalSqrm * price);
        }
    }
}
