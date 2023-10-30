using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main()
        {
            // :100 Dodajte provjere za objekt osoba je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba osoba = new Osoba();
            Console.WriteLine("Osoba");
            Console.WriteLine(osoba.GetType());
            Console.WriteLine(osoba is Osoba); //true
            Console.WriteLine(osoba is Student); //false


            // :101 Dodajte provjere za objekt janko je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba janko = new Student();
            Console.WriteLine("Janko");
            Console.WriteLine(janko.GetType());
            Console.WriteLine(janko is Osoba); //true
            Console.WriteLine(janko is Student); //true


            Console.ReadKey();
        }
    }
}
