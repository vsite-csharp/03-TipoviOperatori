using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent. Dijeljitelj i dijeljenik odabrati tako da dijeljenje bude s ostatkom.
            int a = 5;
            int b = 8;
            Console.WriteLine(a / b);
            // TODO:041 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double c = 3;
            Console.WriteLine(c + a);
            Console.ReadKey();
        }
    }
}
