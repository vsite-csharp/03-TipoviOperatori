namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba
    {
        public void DajOib()
        {
            Console.WriteLine("01234567891");
        }
    }

    class Student : Osoba
    {
        public void PoložiIspit(string predmet)
        {
            Console.WriteLine($"Ocjena iz predmeta {predmet} je 3");
        }
    }

    static class Program
    {
        static void Main()
        {
            // ODO:080 Dodajte pozive svih mogućih metoda nad objektima osoba i student te pokrenite program.
            Osoba osoba = new Osoba();
            osoba.DajOib();

            Student student = new Student();
            student.DajOib();
            student.PoložiIspit("C#");

            // ODO:081 Dodajte pozive svih mogućih metoda na objektu osobaStudent te pokrenite program.
            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();

            // ODO:082 Pokušajte objektu student pridružiti novi objekt tipa Osoba. Provjerite što prevoditelj javlja.
            //Student studentOsoba = new Osoba();

            Console.ReadKey();
        }
    }
}
