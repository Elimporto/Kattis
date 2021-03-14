using System;

namespace jackolanternjuxtaposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(nrOfDesigns(Console.ReadLine()));
        }

        static int nrOfDesigns(string input)
        {
            string[] tempHolder= input.Split(" ");
            int.TryParse(tempHolder[0], out int nrEyeDesigns);
            int.TryParse(tempHolder[1], out int nrNoseDesigns);
            int.TryParse(tempHolder[2], out int nrMouthDesigns);
            return nrEyeDesigns * nrNoseDesigns * nrMouthDesigns;
        }
    }
}
