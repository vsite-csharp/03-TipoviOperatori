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
            // :070 Definirati varijablu "s" tipa dynamic i inicijalizirati ju pozivom konstruktora strukture S definirane gore.
            dynamic s = new S();
            //compileru zanemari sve provjere tijekom izvedbe operacije, no u nekom trenutku će biti exception
            // 071 Napisati naredbe za postavljanje vrijednosti polja a i b u toj strukturi na proizvoljne vrijednosti i provjeriti da li se kod može prevesti.
            //s.a = 23.4;
            s.a = 234;
            // 072 Dodati naredbe za ispis polja a i b u toj strukturi.
            s.b = 123M;

            // 073 Napisati naredbu za postavljanje vrijednosti npostojećeg polja c u toj strukturi na proizvoljnu vrijednosti i provjeriti da li se kod može prevesti.
            s.c = "hello";
            //tijekom builda nije radio provjeru(compiler nije radio provjeru), no tijekom runtime-a je izbacio exception
            // 074 Pokrenuti program i provjeriti ispis.

            Console.ReadKey();
        }
    }
}
