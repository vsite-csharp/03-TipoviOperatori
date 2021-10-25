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
            bool daLiJeOsoba = osoba is Osoba;
            bool dalijeStudent = osoba is Student;
            if (daLiJeOsoba)
                Console.WriteLine("objekt osoba je tipa Osoba");
            if (dalijeStudent)
                Console.WriteLine("objekt osoba je tipa Student");
            else Console.WriteLine("objekt osoba nije tipa Student");


            // Dodajte provjere za objekt janko je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba janko = new Student();
            bool jankoKaoOsoba = janko is Osoba;
            bool jankoKaoStudent = janko is Student;
            if (jankoKaoOsoba)
                Console.WriteLine("objekt janko je tipa Osoba");
            if (jankoKaoStudent)
                Console.WriteLine("objekt janko je tipa Student");
            else Console.WriteLine("objekt janko nije tipa Student");

            Console.ReadKey();
        }
    }
}
