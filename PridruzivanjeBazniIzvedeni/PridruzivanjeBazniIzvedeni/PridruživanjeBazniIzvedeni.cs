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
            // TODO:080 Dodajte pozive svih mogućih metoda nad objektima osoba i student te pokrenite program.
            Osoba osoba = new Osoba();
            osoba.DajOib();

            //console.writeline(osoba.gethashcode());
            //console.writeline(osoba.gettype());
            //console.writeline(osoba.tostring());

            Student student = new Student();

            student.DajOib();
            student.PoložiIspit("Matematika I");

            // TODO:081 Dodajte pozive svih mogućih metoda na objektu osobaStudent te pokrenite program.
            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
            //osobaStudent.PoloziIspit("Fizika");


            // TODO:082 Pokušajte objektu student pridružiti novi objekt tipa Osoba. Provjerite što prevoditelj javlja.
            //student = new osoba();
            //student.položiispit("kemija");

            Console.ReadKey();
        }
    }
}
