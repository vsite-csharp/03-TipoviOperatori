using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int prvi = 21;
            int drugi = 5;
            Console.WriteLine("prvi/drugi={0}", prvi / drugi);
            Console.WriteLine("Tip od prvi/drugi je {0}\n", (prvi/drugi).GetType());

            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine("prvi%drugi={0}", prvi % drugi);
            Console.WriteLine("Tip od prvi%drugi je {0}\n", (prvi % drugi).GetType());

            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int treći = int.MaxValue;
            long duga = 1;
            Console.WriteLine("treći={0}, duga={1}", treći, duga);
            Console.WriteLine("treći+duga={0}", treći+duga);
            Console.WriteLine("Tip od treći+duga je {0}\n", (treći + duga).GetType());


            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double dupla = 42.1;
            int nekaTamo = 58;
            Console.WriteLine("dupla+nekaTamo={0}", dupla + nekaTamo);
            Console.WriteLine("Tip od dupla+nekaTamo je {0}\n", (dupla + nekaTamo).GetType());

            // NE MOŽE SE ZBRAJATI? 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal decVar = 6.812M;
            double dupla2 = 3.188;
            //Console.WriteLine("decVar+dupla2={0}", decVar + dupla2);
            //Console.WriteLine("Tip od dupla+nekaTamo je {0}\n", (decVar + dupla2).GetType());

            Console.ReadKey();
        }
    }
}
