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
            Osoba osoba = new Osoba();
            osoba.DajOib();

            Student student = new Student();
            student.PoložiIspit("Csh");
            student.DajOib();

            Osoba osobaStudent = new Student();
            
            osobaStudent.DajOib();


            Console.ReadKey();
        }
    }
}
