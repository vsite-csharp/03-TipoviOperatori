using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int prvi = 5;
            int drugi = 2;
            Console.WriteLine((prvi / drugi).GetType());
            // Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine(prvi % drugi);

            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int maxi = int.MaxValue;
            long dugi = 1;
            Console.WriteLine(maxi);
            Console.WriteLine(dugi);
            Console.WriteLine(maxi+dugi);

            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double nesto = 2D;
            
            Console.WriteLine((nesto + prvi).GetType());

            // Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal dec = 3M;
            //Console.WriteLine((dec + nesto).GetType());

            Console.ReadKey();
        }
    }
}
