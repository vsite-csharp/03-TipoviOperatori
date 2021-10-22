using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main()
        {
            // Dodajte provjere za objekt osoba je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba osoba = new Osoba();
            if (osoba is Osoba)
            {
                Console.WriteLine("osoba je Osoba :-)");
            }
            if(osoba is Student)
            {
                Console.WriteLine("osoba je Student :-)");
            }

            // Dodajte provjere za objekt janko je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba janko = new Student();
            if (janko is Osoba)
            {
                Console.WriteLine("janko je Osoba :-)");
            }
            if (janko is Student)
            {
                Console.WriteLine("janko je Student :-)");
            }


            Console.ReadKey();
        }
    }
}
