using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // :040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int prvi = 10;
            int drugi = 20;
            var rez = prvi / drugi;
            Console.WriteLine((rez.GetType()));
            // :041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            var modRez = (float)prvi/drugi;
            Console.WriteLine(rez);
            // :042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int treci = int.MaxValue;
            long cetvrti = 1;
            Console.WriteLine(treci);
            Console.WriteLine(cetvrti);
            Console.WriteLine(treci+cetvrti);

            // :043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double dVar = 10;
            Console.WriteLine((dVar + prvi).GetType());
            // :044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal decVar = 15;
            //Console.WriteLine((dVar + decVar));
            //Error = + ne može između decimal i double varijabli (različit broj bitova za brojeve...)

            Console.ReadKey();
        }
    }
}
