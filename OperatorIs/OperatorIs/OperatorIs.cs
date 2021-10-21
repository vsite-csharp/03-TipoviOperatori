using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main()
        {
            // 100 Dodajte provjere za objekt osoba je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba osoba = new Osoba();
            if ((osoba.GetType() == typeof(Osoba)) & (osoba.GetType() == typeof(Student))){
                Console.WriteLine("ako ovo vidite, objekt osoba je i tipa Osoba i tipa Student");
            }

            // 101 Dodajte provjere za objekt janko je li tipa Osoba i tipa Student te ispišite rezultate.
            Osoba janko = new Student();
            if ((janko.GetType() == typeof(Osoba)) & (janko.GetType() == typeof(Student))){
                Console.WriteLine("ako ovo vidite, objekt janko je i tipa Osoba i tipa Student");
            }

            Console.ReadKey();
        }
    }
}
