using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // Definirati varijablu "s" tipa dynamic i inicijalizirati ju pozivom konstruktora strukture S definirane gore.
            dynamic s = new S();

            // Napisati naredbe za postavljanje vrijednosti polja a i b u toj strukturi na proizvoljne vrijednosti i provjeriti da li se kod može prevesti.
            s.a = 25.3;
            // Dodati naredbe za ispis polja a i b u toj strukturi.
            s.b = 123M;
            // Napisati naredbu za postavljanje vrijednosti npostojećeg polja c u toj strukturi na proizvoljnu vrijednosti i provjeriti da li se kod može prevesti.
            s.c = "ZDRAVO";
            // Pokrenuti program i provjeriti ispis.

            Console.ReadKey();
        }
    }
}
