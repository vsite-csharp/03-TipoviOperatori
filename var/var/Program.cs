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
        static void Main(string[] args)
        {
            // Dodati varijablu "i0" tipa var i inicijalizirati ju nekim cijelim brojem.
            var i0 = 12;

            // Dodati varijablu "d0" tipa var i inicijalizirati ju nekim decimalnim brojem.
            var d0 = 3.14;

            // Dodati naredbu: i0 = d0; te provjeriti prihvaća li prevoditelj tu naredbu.
            //i0 = d0;

            // Dodati varijablu "i1" tipa int i inicijalizirati ju istim cijelim brojem kao varijablu i0.
            int i1 = 12;

            // Dodati varijablu "d1" tipa double i inicijalizirati ju istim decimalnim brojem kao varijablu d0.
            double d1 = 3.14;

            // TODO:065 Prevesti kod i usporediti kod naredbi za inicijalizacije varijabli i0 i d0, odnosno i1 i d1 pomoću ILDasm-a.


            // TODO:066 Deklarirati varijablu "s" tipa var i inicijalizirati ju pozivom konstruktora strukture S definirane gore.


            // TODO:067 Napisati naredbe za postavljanje vrijednosti polja a i b u toj strukturi na proizvoljne vrijednosti i provjeriti da li se kod može prevesti.


            Console.ReadKey();
        }
    }
}
