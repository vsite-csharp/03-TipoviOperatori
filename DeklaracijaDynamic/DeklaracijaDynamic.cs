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
            // :070 Definirati varijablu "s" tipa dynamic i inicijalizirati ju pozivom konstruktora strukture S definirane gore.
            dynamic s = new S();
            // :071 Napisati naredbe za postavljanje vrijednosti polja a i b u toj strukturi na proizvoljne vrijednosti i provjeriti da li se kod može prevesti.
            s.a = 54;
            s.b = 234;

            Console.WriteLine(s.a);
            Console.WriteLine(s.b);
            // TODO:072 Dodati naredbe za ispis polja a i b u toj strukturi.

            // :073 Napisati naredbu za postavljanje vrijednosti nepostojećeg polja c u toj strukturi na proizvoljnu vrijednosti i provjeriti da li se kod može prevesti.
            s.c = "Pero";
            Console.WriteLine(s.c); 
            // :074 Pokrenuti program i provjeriti ispis.

            Console.WriteLine ("GOTOVO");
            Console.ReadKey();
        }
    }
}
