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
            //  Dodajte pozive svih mogućih metoda nad objektima osoba i student te pokrenite program.
            Osoba osoba = new Osoba();
            osoba.DajOib();
            osoba.GetType();
            osoba.GetHashCode();
            osoba.ToString();
            osoba.Equals(osoba);
            Student student = new Student();
            student.PoložiIspit("csh");
            student.Equals(student);
            student.DajOib();
            student.GetHashCode();
            student.GetType();
            student.ToString();
            //  Dodajte pozive svih mogućih metoda na objektu osobaStudent te pokrenite program.
            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
            osobaStudent.Equals(osoba);
            osobaStudent.GetHashCode();
            osobaStudent.GetType();
            osobaStudent.ToString();
            //  Pokušajte objektu student pridružiti novi objekt tipa Osoba. Provjerite što prevoditelj javlja.
            //Student studentOsoba = new Osoba();
            //Student studentOsoba = student + osoba;

            Console.ReadKey();
        }
    }
}
