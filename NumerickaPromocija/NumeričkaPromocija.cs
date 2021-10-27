using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // :040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            var first = 5;
            var second = 2;
            var quotient = first / second;
            Console.WriteLine($"Tip: {quotient.GetType()}");

            // :041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine($"Dijeljenje s ostatkom: {first/(double)second}");

            // :042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            var maxValue = int.MaxValue;
            var lVar = 1l;
            Console.WriteLine($"Zbroj {maxValue} + {lVar} = {maxValue + lVar}");

            // :043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            var dvar = 3.4;
            var ivar = 5;
            Console.WriteLine($"Zbroj varijabli tipova double i int je tipa {(dvar + ivar).GetType()}");

            // :044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            var decimalVar = 3.4M;
            //Console.WriteLine($"Zbroj varijabli tipova decimal i double je tipa {(decimalVar + dvar).GetType()}");
            //Nije moguce zbrojiti varijable tipa decimal i double jer nije moguce implicitno convertirati double u decimal, niti obrnuto

            Console.ReadKey();
        }
    }
}
