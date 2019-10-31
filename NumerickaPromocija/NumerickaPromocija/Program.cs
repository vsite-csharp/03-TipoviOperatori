using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent. Dijeljitelj i dijeljenik odabrati tako da dijeljenje bude s ostatkom.
            int x = 5;int y = 10;
            Console.WriteLine(x / y);
            // TODO:041 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double d = 3.14;
            Console.WriteLine(x + d);
            x = (int)(x + d);
            Console.ReadKey();
        }
    }
}
