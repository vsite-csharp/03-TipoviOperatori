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
                Console.WriteLine("Osoba je tipa Osoba");
            else
                Console.WriteLine("Osoba nije tipa Osoba")
            if (osoba is Student)
                Console.WriteLine("Osoba je tipa student");
            else
                Console.WriteLine("Osoba nije tipa student")
            // Dodajte provjere za objekt janko je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba janko = new Student();

            if (janko is Osoba)
                Console.WriteLine("Osoba je tipa Osoba");
            else
                Console.WriteLine("Osoba nije tipa Osoba")
            if (janko is Student)
                Console.WriteLine("Osoba je tipa student");
            else
                Console.WriteLine("Osoba nije tipa student")

            Console.ReadKey();
        }
    }
}
