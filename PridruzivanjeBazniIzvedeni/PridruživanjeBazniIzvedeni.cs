using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba
    {
        public void DajOib()
        {
            Console.WriteLine("0123456789");
        }
    }

    class Student : Osoba
    {
        public void PoložiIspit(string predmet)
        {
            Console.WriteLine($"Ocjena iz predmeta {predmet} je 3");
        }
    }

    class Program
    {
        static void Main()
        {
            // :080 Dodajte pozive svih mogućih metoda nad objektima osoba i student te pokrenite program.
            Osoba osoba = new Osoba();
            osoba.DajOib();
            Student student = new Student();
            student.PoložiIspit("Matematika");
            student.DajOib();
            // :081 Dodajte pozive svih mogućih metoda na objektu osobaStudent te pokrenite program.
            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
            // :082 Pokušajte objektu student pridružiti novi objekt tipa Osoba. Provjerite što prevoditelj javlja.
            //student = new Osoba();

            Console.ReadKey();
        }
    }
}
