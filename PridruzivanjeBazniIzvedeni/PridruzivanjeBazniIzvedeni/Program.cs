using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba
    {
        public string DajOib()
        {
            return "0123456789";
        }
    }

    class Student : Osoba
    {
        public int PoložiIspit(string predmet)
        {
            return 5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.DajOib();
            Student student = new Student();
            student.DajOib();
            student.PoložiIspit("CSH");
            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
            ((Student)osobaStudent).PoložiIspit("Fizika");
            //((Student)osoba).PoložiIspit("Fizika");
            //Student studentOsoba = new Osoba();

            Console.ReadKey();
        }
    }
}
