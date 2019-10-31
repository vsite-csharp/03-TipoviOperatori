using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            Console.WriteLine(osoba is Osoba);
            Console.WriteLine(osoba is Student);

            Osoba janko = new Student();
            Console.WriteLine(janko is Osoba);
            Console.WriteLine(janko is Student);

            Student Ivan = new Student();
            Console.WriteLine(Ivan is Osoba);
            Console.WriteLine(Ivan is Student);


            Console.ReadKey();
        }
    }
}
