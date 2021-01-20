using System;
//hi
namespace QuadrantSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int x);
            Int32.TryParse(Console.ReadLine(), out int y);

            if(x>0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if(x<0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else if(x<0 && y < 0)
            {
                Console.WriteLine("3");
            }
            else if(x>0 && y < 0)
            {
                Console.WriteLine("4");
            }
        }
    }
}
