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
            
            var i0 = 12;    //integer
            
            var d0 = 3.14;  //biti će double

            //i0 = d0;  kompajler javlja grašku
            int i1 = 12;
            
            double d1 = 3.14;
            // TODO:065 Prevesti kod i usporediti kod naredbi za inicijalizacije varijabli i0 i d0, odnosno i1 i d1 pomoću ILDasm-a.
            //dz
            // TODO:066 Deklarirati varijablu "s" tipa var i inicijalizirati ju pozivom konstruktora strukture S definirane gore.
            //dz
            // TODO:067 Napisati naredbe za postavljanje vrijednosti polja a i b u toj strukturi na proizvoljne vrijednosti i provjeriti da li se kod može prevesti.
            //dz

            Console.ReadKey();
        }
    }
}
