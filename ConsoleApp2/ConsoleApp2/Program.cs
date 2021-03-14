using System;

class Program
{

    public static void Main(String[] args)
    {
        /* ConsoleApp2.Person person = new ConsoleApp2.Person();

         string[] personer = new string[5];
         personer[0] = person.Beskrivning("Jesper", 12, "Röd");
         personer[1] = person.Beskrivning("Karen", 99, "Lila");
         personer[2] = person.Beskrivning("Juan", 11, "Blått");
         personer[3] = person.Beskrivning("Giuseppe", 15, "Svart");
         personer[4] = person.Beskrivning("Raja", 19, "Vitt");

         foreach(string index in personer)
         {
             Console.WriteLine(index);
         }*/
       int number = 100;
        Console.WriteLine(Clamp(ref number));
        GoodNumbers(out int x, out int y);
        Console.WriteLine(x);
        Console.WriteLine(y);

    }
    public static int Clamp(ref int number)
    {
        if (number > 110)
            return number = 100;
        else
            return number;
    }
    public static void GoodNumbers(out int x, out int y)
    {
        Random random = new Random();
        x = random.Next(1, 100);
        y = random.Next(1, 100);
    }
    public static 

}