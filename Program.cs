using System;

namespace Interfejsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Racun r = new Racun("Petar", "Petrovic", 2000);
            r.stampaj();
            Console.WriteLine();
            
            Console.ReadLine();

            Console.WriteLine("Uplata: 1500...");
            Console.WriteLine();
            r.Uplata(1500);
            r.stampaj();
            Console.WriteLine();

            Console.ReadLine();

            Console.WriteLine("Isplata 1200...");
            Console.WriteLine();
            r.Isplata(1200);
            r.stampaj();
            Console.WriteLine();

            Console.ReadLine();

            Console.WriteLine("Isplata 4000...");
            Console.WriteLine();
            r.Isplata(4000);

            Console.WriteLine();
            Console.WriteLine("Kraj programa...");
            Console.ReadLine();
        }
    }
}
