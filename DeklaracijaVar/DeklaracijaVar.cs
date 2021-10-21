using System;

namespace Vsite.CSharp.TipoviOperatori
{
    struct S
    {
        public int a;
        public double b;
    }

    class Program
    {
        static void Main()
        {
            // Definirati varijablu "i0" tipa var i inicijalizirati ju nekim cijelim brojem.
            var i0 = 5;

            // Definirati varijablu "d0" tipa var i inicijalizirati ju nekim decimalnim brojem.
            var d0 = 2.3;

            // Dodati naredbu: i0 = d0; te provjeriti prihvaća li prevoditelj tu naredbu.
            //i0 = d0;

            // Definirati varijablu "i1" tipa int i inicijalizirati ju istim cijelim brojem kao varijablu i0.
            int i1 = 5;

            // Definirati varijablu "d1" tipa double i inicijalizirati ju istim decimalnim brojem kao varijablu d0.
            double d1 = 2.3;


            // Definirati varijablu "s" tipa var i inicijalizirati ju pozivom konstruktora strukture S definirane gore.
            var s = new S();

            // Napisati naredbe za postavljanje vrijednosti polja a i b u toj strukturi na proizvoljne vrijednosti i provjeriti da li se kod može prevesti.
            s.a = 123;
            s.b = 1.23;

            // Napisati naredbu za postavljanje vrijednosti npostojećeg polja c u toj strukturi na proizvoljnu vrijednosti i provjeriti da li se kod može prevesti.
            //s.c = 23;

            Console.ReadKey();
        }
    }
}
