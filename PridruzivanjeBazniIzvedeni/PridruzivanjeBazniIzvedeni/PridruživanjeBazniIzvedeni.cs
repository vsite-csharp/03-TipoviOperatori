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
            // Dodajte pozive svih mogućih metoda nad objektima osoba i student te pokrenite program.
            Osoba osoba = new Osoba();
            osoba.DajOib();
            //Console.WriteLine(osoba.GetHashCode());
            //Console.WriteLine(osoba.GetType());
            //Console.WriteLine(osoba.ToString());

            Student student = new Student();
            student.DajOib();
            student.PoložiIspit("Matematika I ");

            // Dodajte pozive svih mogućih metoda na objektu osobaStudent te pokrenite program.
            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
           

            // Pokušajte objektu student pridružiti novi objekt tipa Osoba. Provjerite što prevoditelj javlja.


            Console.ReadKey();
        }
    }
}
