using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // ODO:040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int prvi = 17;
            int drugi = 12;
            Console.WriteLine(prvi / drugi);

            // ODO:041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            double treci = (double)prvi;
            Console.WriteLine(treci / drugi);
            // ODO:042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int neki = int.MaxValue;
            long taki = 1;
            Console.WriteLine("Integer: " + neki + "\nLong: " + taki + "\nZbroj: " + (neki + taki));
            // ODO:043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double ovaki = 12;
            Console.WriteLine((ovaki + taki).GetType());
            // ODO:044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal fling = 3.14m;
            double ding = 12.5;
            //Console.WriteLine((fling + ding).GetType()); Javlja grešku da se ta dva tipa ne mogu zbrajati.
            Console.ReadKey();
        }
    }
}
