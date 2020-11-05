using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main()
        {
            // TODO:100 Dodajte provjere za objekt osoba je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba osoba = new Osoba();
            if (osoba is Osoba)
                Console.WriteLine("osoba je tipa Osoba");
            else
                Console.WriteLine("osoba nije tipa Osoba");
            if (osoba is Student)
                Console.WriteLine("osoba je tipa Student");
            else
                Console.WriteLine("osoba nije tipa Student");

            // TODO:101 Dodajte provjere za objekt janko je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba janko = new Student();
            if (janko is Osoba)
                Console.WriteLine("janko je tipa Osoba");
            else
                Console.WriteLine("janko nije tipa Osoba");
            if (janko is Student)
                Console.WriteLine("janko je tipa Student");
            else
                Console.WriteLine("janko nije tipa Student");

            Console.ReadKey();
        }
    }
}
