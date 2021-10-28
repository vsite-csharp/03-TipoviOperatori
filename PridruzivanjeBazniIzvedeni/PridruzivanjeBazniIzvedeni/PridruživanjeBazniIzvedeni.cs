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
            osoba.DajOib();
            osoba.GetType();
            osoba.GetHashCode();
            osoba.ToString();
            osoba.Equals(osoba);

            Student student = new Student();

            student.DajOib();
            student.GetType();
            student.GetHashCode();
            student.ToString();
            student.Equals(student);
            student.PoložiIspit("Fizika");
            
            // 081 Dodajte pozive svih mogućih metoda na objektu osobaStudent te pokrenite program.
            Osoba osobaStudent = new Student();

            osobaStudent.DajOib();
            osobaStudent.GetType();
            osobaStudent.GetHashCode();
            osobaStudent.ToString();
            osobaStudent.Equals(osobaStudent);

            // 082 Pokušajte objektu student pridružiti novi objekt tipa Osoba. Provjerite što prevoditelj javlja.
            //Student stud = new Osoba();

            Console.ReadKey();
        }
    }
}
