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
            // 080 Dodajte pozive svih mogućih metoda nad objektima osoba i student te pokrenite program.
            Osoba osoba = new Osoba();

            Student student = new Student();

            osoba.DajOib();
            student.PoložiIspit("Linearna algebra");
            student.DajOib();

            // 081 Dodajte pozive svih mogućih metoda na objektu osobaStudent te pokrenite program.
            Osoba osobaStudent = new Student();

            osobaStudent.DajOib();
            //osobaStudent.PoložiIspit("Linearna algebra"); It is not possible because it is instance Osoba

            //Student s = new Osoba();  It is not possible BAZNOM MOŽEMO PRIDRUŽITI IZVEDENI 

            // 082 Pokušajte objektu student pridružiti novi objekt tipa Osoba. Provjerite što prevoditelj javlja.

            //student = new Osoba(); Cannot implicitly convert type 'type1' to 'type2'. An explicit conversion exists (are you missing a cast?)

            Console.ReadKey();
        }
    }
}
