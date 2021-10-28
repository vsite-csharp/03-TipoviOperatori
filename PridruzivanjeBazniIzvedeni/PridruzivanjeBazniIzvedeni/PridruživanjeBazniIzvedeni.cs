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

    //svaki student je osoba, student je izveden iz klase osoba
    //student nasljeduje sve od klase osobe - metoda dajOib
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
            Osoba osoba = new Osoba(); //automatski prazni konstruktor
            osoba.DajOib();

            Student student = new Student();
            student.DajOib();
            student.PoložiIspit("Ocjena iz predmeta u C#");

            // 081 Dodajte pozive svih mogućih metoda na objektu osobaStudent te pokrenite program.
            Osoba osobaStudent = new Student(); //pridruzujes baznom tipu izvedeni i kompajler to dopusta
            osobaStudent.DajOib(); // moze samo dajoib, ali ne i poloziispit

            // 082 Pokušajte objektu student pridružiti novi objekt tipa Osoba. Provjerite što prevoditelj javlja.
            //Student s = new Osoba(); //ne mogu implicitno pretvorititi izvedeni u bazni, kompajler javlja gresku
            //s.PoložiIspit(); //

            Console.ReadKey();
        }
    }
}
