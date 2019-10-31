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
            
            Osoba osoba = new Osoba();
            osoba.DajOib();
            

            Student student = new Student();
            student.DajOib();
            student.PoložiIspit("Bate podataka");
            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
            // TODO:071 Deklarirajte objekt tipa Student i pokušajte ga instancirati pozivom konstruktora tipa Osoba. Provjerite što prevoditelj javlja.
            ((Student)osobaStudent).PoložiIspit("Fizika");  //ne preporučuje se...eksplicitni cast je riskantan!
                                                            // ((Student)osoba).PoložiIspit("Fizika"); //System.InvalidCastException
            //Student studentKaoOsoba = new Osoba(); ..bazni tip ne možeš u izvedeni jedino castom ali na vlastitu odgovornost!
            //studentKaoOsoba.PoložiIspit();
            Console.ReadKey();
        }
    }
}
