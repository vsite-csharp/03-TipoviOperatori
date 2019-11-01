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
            Osoba osoba2 = new Student();
            Osoba osoba3 = new NuklearniFizičar();
            Student student = new Student();
            //Student student2 = (Student) new Osoba();
            //Student student3 = (Student) (Osoba) new NuklearniFizičar();
            NuklearniFizičar nuklFiz = new NuklearniFizičar();
            //NuklearniFizičar nuklFiz2 = (NuklearniFizičar) new Osoba();
            //NuklearniFizičar nuklFiz3 = (NuklearniFizičar) (Osoba) new Student();

            Osoba osobaStudent = new Student();
            Osoba osobaNuklFiz = new NuklearniFizičar();

            osobaStudent = student;
            osobaNuklFiz = nuklFiz;

            ((Student)osobaStudent).PoložiIspit();
            ((NuklearniFizičar)osobaNuklFiz).NapraviBombu();

            student = (Student) osobaStudent;
            nuklFiz = (NuklearniFizičar) osobaNuklFiz;

            student.PoložiIspit();
            nuklFiz.NapraviBombu();


            Console.WriteLine("\nStudent\n----------------");
            Student s1 = new Student();

            Console.WriteLine(s1.Equals(student));
            s1.GetHashCode();
            s1.GetType();
            s1.Hodaj();
            s1.PoložiIspit();
            s1.ToString();


            Console.WriteLine("\nFizičar\n----------------");
            NuklearniFizičar n1 = new NuklearniFizičar();

            Console.WriteLine(n1.Equals(nuklFiz));
            n1.GetHashCode();
            n1.GetType();
            n1.Hodaj();
            n1.NapraviBombu();
            n1.ToString();

            Console.WriteLine("\nosobaS\n----------------");
            Osoba osobaS = student;

            Console.WriteLine(osobaS.Equals(student));
            osobaS.GetHashCode();
            osobaS.GetType();
            osobaS.Hodaj();
            osobaS.ToString();
            ((Student)osobaS).PoložiIspit();

            Console.WriteLine("\nsos\n----------------");
            Student sos = (Student)osobaS;

            Console.WriteLine(sos.Equals(student));
            sos.GetHashCode();
            sos.GetType();
            sos.Hodaj();
            sos.PoložiIspit();
            sos.ToString();

            Console.WriteLine();


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
