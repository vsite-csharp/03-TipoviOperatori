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
            // TODO:070 Definirati varijablu "s" tipa dynamic i inicijalizirati ju pozivom konstruktora strukture S definirane gore.
            dynamic s = new S();
            // TODO:071 Napisati naredbe za postavljanje vrijednosti polja a i b u toj strukturi na proizvoljne vrijednosti i provjeriti da li se kod može prevesti.
            s.a = 3;
            s.b = "Pero";
            // TODO:072 Dodati naredbe za ispis polja a i b u toj strukturi.
            Console.WriteLine(s.a);
            Console.WriteLine(s.b);
            // TODO:073 Napisati naredbu za postavljanje vrijednosti nepostojećeg polja c u toj strukturi na proizvoljnu vrijednosti i provjeriti da li se kod može prevesti.
            //s.c = 3;
            // TODO:074 Pokrenuti program i provjeriti ispis.

            Console.ReadKey();
        }
    }
}
