namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            // :040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 5;
            int b = 2;
            var c = a / b;  // int
            Console.WriteLine(c);  

            // :041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.

            // :042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int d = int.MaxValue;
            long e = 1;
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(d+e);


            // :043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double f = 5.3;
            int g = 2;
            var h = f + g;  // double
            Console.WriteLine(f+g);

            // :044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal i = 3.14m;
            double j = 4.21;
            //var k = i + j;  // operator + cannot be applied to operands of type double and decimal
            //Console.WriteLine(k);

            Console.ReadKey();
        }
    }
}
