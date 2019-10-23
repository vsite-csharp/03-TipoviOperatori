namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            // :040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 1;
            int b = 2;
            Console.Write(a / b);
            // :041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.Write(a % b);

            // :042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int c = int.MaxValue;
            long d = 1;
            Console.Write(c);
            Console.Write(d);
            Console.Write(c +d);
            // :043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double e = 3;
            e += a;
            Console.Write(e.GetType);
            double f = 2.3;
            // :044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal g = 0.3m;
            //Console.Write(g + f);

            Console.ReadKey(); 
        }
    }
}
