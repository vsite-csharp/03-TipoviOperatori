namespace Vsite.CSharp.TipoviOperatori
{
    struct S
    {
        public int a;
        public double b;
    }

    static class Program
    {
        static void Main()
        {
            //  Definirati varijablu "i0" tipa var i inicijalizirati ju nekim cijelim brojem.

            var i0 = -12;

            // Definirati varijablu "d0" tipa var i inicijalizirati ju nekim decimalnim brojem.

            var d0 = 1.34F;

            // Dodati naredbu: i0 = d0; te provjeriti prihvaća li prevoditelj tu naredbu.

            i0 = (int)d0;

            // Definirati varijablu "i1" tipa int i inicijalizirati ju istim cijelim brojem kao varijablu i0.

            int li = 15;

            // Definirati varijablu "d1" tipa double i inicijalizirati ju istim decimalnim brojem kao varijablu d0.

            double di = 1.34;

            // Prevesti kod i usporediti kod naredbi za inicijalizacije varijabli i0 i d0, odnosno i1 i d1 pomoću ILDasm-a.



            // Definirati varijablu "s" tipa var i inicijalizirati ju pozivom konstruktora strukture S definirane gore.

            var s = new S();

            // Napisati naredbe za postavljanje vrijednosti polja a i b u toj strukturi na proizvoljne vrijednosti i provjeriti da li se kod može prevesti.

            s.a = 15;
            s.b = 2.76;

            // Napisati naredbu za postavljanje vrijednosti npostojećeg polja c u toj strukturi na proizvoljnu vrijednosti i provjeriti da li se kod može prevesti.

            //s.c = 13;

            Console.ReadKey();
        }
    }
}
