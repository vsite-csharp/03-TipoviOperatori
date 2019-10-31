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
            return 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Dodajte pozive svih mogućih metoda nad instancama objekata osoba, student i osobaStudent.
            Osoba osoba = new Osoba();
            osoba.DajOib();

            Student student = new Student();
            student.DajOib();
            student.PoložiIspit("KRIP");

            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
            ((Student)osobaStudent).PoložiIspit("Etika poslovanja");
            //((Student)osoba).PoložiIspit("Etika poslovanja");

            // Deklarirajte objekt tipa Student i pokušajte ga instancirati pozivom konstruktora tipa Osoba. Provjerite što prevoditelj javlja.
            //Student studentKaoOsoba = new Osoba();
            //studentKaoOsoba.PoložiIspit();

            Console.ReadKey();
        }
    }
}
