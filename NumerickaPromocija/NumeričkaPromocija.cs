namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            //040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int i = 1; int j = 2;
            Console.WriteLine(i/j); //tipa int 

            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine((double)i/j);
            //042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int a = int.MaxValue;
            long b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a+b);
            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double d = 10;
            int i2 = 11;
            Console.WriteLine((d+i2).GetType()); // biti će tipa double
            //044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal d2 = 1.23m;
            double d3 = 1.32;
            //Console.WriteLine((d2+d3).GetType()); biti će greška jer se ne mogu zbrojiti ta dva tipa bez pretvorbe
            Console.ReadKey();
        }
    }
}
