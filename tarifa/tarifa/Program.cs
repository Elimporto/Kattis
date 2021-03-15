using System;

namespace tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int X);
            int.TryParse(Console.ReadLine(), out int N);
            Console.WriteLine(Tarifa(X,N));
        }
        static int Tarifa(int X, int N)
        {
            int output = X * (N+1);
            for(int i = 0; i < N; i++)
            {
                int.TryParse(Console.ReadLine(), out int P);
                output -= P;
            }

            return output;
        }
    }
}
