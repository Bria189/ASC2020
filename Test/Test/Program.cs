using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Scrie marimea de la pantof:");

            string line;
            line = Console.ReadLine();

            int numarPantof;
            numarPantof = int.Parse(line);

            Console.WriteLine($"Aveti {numarPantof} numarul la pantof");
        }
    }
}
