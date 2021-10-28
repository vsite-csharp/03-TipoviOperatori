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
            Console.WriteLine($"Ocjena iz predmeta {predmet} je 3 + 2");
            Console.WriteLine("which equals 5.\nCongratulations!");
        }
    }

    class Program
    {
        static void Main()
        {
            // Dodajte pozive svih mogućih metoda nad objektima osoba i student te pokrenite program.
            Osoba osoba = new Osoba();
            osoba.DajOib();

            Student student = new Student();
            student.DajOib();
            student.PoložiIspit("c-sharp");

            // Dodajte pozive svih mogućih metoda na objektu osobaStudent te pokrenite program.
            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
            //osobaStudent.PoloziIspit()  NENE

            // Pokušajte objektu student pridružiti novi objekt tipa Osoba. Provjerite što prevoditelj javlja.
            //student = new Osoba(); //OVO SE TOVE IMPLICITNO KONVERTANJE, NEMORE
            //student = (Student)new Osoba();   //OVO EKSPLICITNO, unable to cast System.InvalidCastException
            //student.PoložiIspit("C^2");

            Console.ReadKey();
        }
    }
}
