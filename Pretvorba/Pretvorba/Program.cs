using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba
    {
        public void Hodaj()
        {
            Console.WriteLine("Hodam");
        }
    }

    class Student : Osoba
    {
        public void PoložiIspit()
        {
            Console.WriteLine("Položio sam ispit");
        }
    }

    class NuklearniFizičar : Osoba
    {
        public void NapraviBombu()
        {
            Console.WriteLine("Bum");
        }
    }


    class Program
    {
        static void Main()
        {
            // TODO:080 Provjeriti za koja pridruživanja se smije  staviti operator pretvorbe da prevoditelj ne bi prijavio pogrešku a da pri izvođenju ne bude bačena iznimka.
            Osoba osoba = new Osoba();
            Student student = new Student();
            NuklearniFizičar nuklFiz = new NuklearniFizičar();

            Osoba osobaStudent = new Student();
            Osoba osobaNuklFiz = new NuklearniFizičar();

            // TODO:081 Provjeriti koja su od donjih pridruživanja dozvoljena.
            osobaStudent = student;
            osobaNuklFiz = nuklFiz;

            // TODO:082 Otkomentirati donje naredbe i provjeriti jesu li dozvoljene.
            // student = osobaStudent;
            // nuklFiz = osobaNuklFiz;

            // TODO:083 Dodati sve moguće pozive metoda za objekt student


            // TODO:084 Dodati sve moguće pozive metoda za objekt nuklFiz


            Osoba osobaS = student;
            // TODO:085 Dodati sve moguće pozive metoda za osobaS


            // TODO:086 Otkomenitari donju naredbu i dodati sve moguće pozive metoda za sos.
            // Student sos = osobaS;


            Osoba osobaA = osobaNuklFiz;
            nuklFiz = (NuklearniFizičar)osobaA;
            nuklFiz.Hodaj();
            nuklFiz.NapraviBombu();

            osobaA = osoba;
            nuklFiz = (NuklearniFizičar)osobaA;
            nuklFiz.Hodaj();
            nuklFiz.NapraviBombu();


            Console.ReadKey();
        }
    }
}
