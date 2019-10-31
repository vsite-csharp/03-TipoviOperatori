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
            Console.WriteLine(osoba is Osoba);  //true
            Console.WriteLine(osoba is Student);//false


            
            Osoba janko = new Student();
            Console.WriteLine(janko is Osoba);  //true
            Console.WriteLine(janko is Student);//true

            Student ivan = new Student();
            Console.WriteLine(ivan is Osoba);  //true..zato što je bazni tip
            Console.WriteLine(ivan is Student);//true

            Console.ReadKey();
        }
    }
}
