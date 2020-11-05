using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main()
        {
            //  Dodajte provjere za objekt osoba je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba osoba = new Osoba();
            if (osoba is Osoba)
                Console.WriteLine("osoba je tipa osoba.");
            else
                Console.WriteLine("nije tipa osoba");

            if (osoba is Student)//ovo nije tocno
                Console.WriteLine("osoba je tipa student.");
            else
                Console.WriteLine("nije tipa student");

            //  Dodajte provjere za objekt janko je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba janko = new Student();
            if (janko is Osoba)
                Console.WriteLine("janko je tipa osoba.");
            else
                Console.WriteLine("nije tipa osoba");

            if (janko is Student)//tu ce se ispisat jer smo ga pridruzili osobu kao novi student
                Console.WriteLine("janko  je tipa student.");
            else
                Console.WriteLine("nije tipa student");

            Console.ReadKey();
        }
    }
}
