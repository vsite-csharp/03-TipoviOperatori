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
                Console.WriteLine("osoba je tipa Osoba");
            }
            else
            {
                Console.WriteLine("osoba NIJE tipa Osoba");
            }
            if (osoba is Student)
                Console.WriteLine("osoba je tipa Student");
            else
            {
                Console.WriteLine("osoba NIJE tipa Student");
            }
            // Dodajte provjere za objekt janko je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba janko = new Student();
            if (janko is Osoba)
            {
                Console.WriteLine("janko je tipa Osoba");
            }
            else
            {
                Console.WriteLine("janko NIJE tipa Osoba");
            }
            if (janko is Student)
                Console.WriteLine("janko je tipa Student");
            else
            {
                Console.WriteLine("janko NIJE tipa Student");
            }

            Console.ReadKey();
        }
    }
}
