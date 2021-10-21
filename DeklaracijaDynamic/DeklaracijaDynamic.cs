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
        public Object ispis()
        {
            try
            {
                Console.WriteLine("s.a(int) = {}, a s.b(double) = {}", a, b);
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            
        }
    }

    class Program
    {
        static void Main()
        {
            // 070 Definirati varijablu "s" tipa dynamic i inicijalizirati ju pozivom konstruktora strukture S definirane gore.
            dynamic s = new S();

            // 071 Napisati naredbe za postavljanje vrijednosti polja a i b u toj strukturi na proizvoljne vrijednosti i provjeriti da li se kod može prevesti.
            s.a = 10;
            s.b = 3.14;

            // 072 Dodati naredbe za ispis polja a i b u toj strukturi.
            s.ispis();
            // 073 Napisati naredbu za postavljanje vrijednosti npostojećeg polja c u toj strukturi na proizvoljnu vrijednosti i provjeriti da li se kod može prevesti.
            s.c = 4;
            // 074 Pokrenuti program i provjeriti ispis.
            s.ispis();
            Console.ReadKey();
        }
    }
}
