using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int var1 = 20;
            int var2 = 10;
            int kvocijent = var1 / var2;
            Console.WriteLine($"Kvocijent dvije varijable tipa int je tipa {kvocijent.GetType()}"); //System.Int32, iznos = 2

            // Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            var1 = 23;
            kvocijent = 23 / 10;
            Console.WriteLine($"Iznos i tip kvocijenta: {kvocijent}, {kvocijent.GetType()}"); //2, System.Int32

            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int intMax = int.MaxValue;
            long dugi = 1L;
            Console.WriteLine($"intMax = {intMax}, dugi = {dugi}, intMax + dugi = {intMax+dugi}"); //iznos 2147483648, tip System.Int64

            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            int nekiInt = 26;
            double nekidouble = 4.4;
            Console.WriteLine($"Zbroj varijabli tipa int i double je tipa {(nekiInt + nekidouble).GetType()}"); //tip System.Double

            // Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal nekiDecimal = 26M;
            //Console.WriteLine($"Zbroj varijabli tipa decimal i double je tipa {(nekiDecimal + nekidouble).GetType()}"); //varijable tipa decimal i double ne mogu se zbrajati

            Console.ReadKey();
        }
    }
}
