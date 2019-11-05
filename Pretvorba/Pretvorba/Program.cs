using System;

namespace Vsite.Csharp.TipoviOperatori
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
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            Student student = new Student();
            NuklearniFizičar nuklFiz = new NuklearniFizičar();

            Osoba osobaStudent = new Student();
            Osoba osobaNuklFiz = new NuklearniFizičar();
            
            osobaStudent = student;
            osobaNuklFiz = nuklFiz;

            //student = osobaStudent;
            //nuklFiz = osobaNuklFiz;

            student.Hodaj();
            student.PoložiIspit();

            nuklFiz.Hodaj();
            nuklFiz.NapraviBombu();

            Osoba osobaS = student;
            osobaS.Hodaj();

            //Student sos = osobaS;
            //sos.Hodaj();
            //sos.PoložiIspit();

            Osoba osobaA = osobaNuklFiz;
            nuklFiz = (NuklearniFizičar)osobaA;
            nuklFiz.Hodaj();
            nuklFiz.NapraviBombu();

            osobaA = osoba;
            //nuklFiz = (NuklearniFizičar)osobaA;
            nuklFiz.Hodaj();
            nuklFiz.NapraviBombu();

            Console.ReadKey();
        }
    }
}
