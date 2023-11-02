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
            // 070 Definirati varijablu "s" tipa dynamic i inicijalizirati ju pozivom konstruktora strukture S definirane gore.
            dynamic s=new S();
            // 071 Napisati naredbe za postavljanje vrijednosti polja a i b u toj strukturi na proizvoljne vrijednosti i provjeriti da li se kod može prevesti.
            s.a = 54;
            s.b = 234;
            // 072 Dodati naredbe za ispis polja a i b u toj strukturi.
            Console.WriteLine(s.a);
            Console.WriteLine(s.b);
            // 073 Napisati naredbu za postavljanje vrijednosti nepostojećeg polja c u toj strukturi na proizvoljnu vrijednosti i provjeriti da li se kod može prevesti.
            s.c = "Aaa";
            // 074 Pokrenuti program i provjeriti ispis.
            Console.WriteLine(s.c);
            //Console.ReadKey();
            Console.WriteLine("'GG'");
        }
    }
}
