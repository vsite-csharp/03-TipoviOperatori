using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int num1 = 4;
            int num2 = 2;
            Console.WriteLine((num1 / num2).GetType());

            // Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            num2 = 3;
            Console.WriteLine((num1 / num2).GetType());

            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int num3 = int.MaxValue;
            long num4 = 1;
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num3 + num4);

            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double a = 2.2;
            int b = 4;
            Console.WriteLine(a + b);
            Console.WriteLine((a + b).GetType());

            // Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal c = 4;
            double d = 2;
            Console.WriteLine(c + (decimal)d); // Operator "+" nije dozvoljen izmedu tipa decimal i double
            Console.WriteLine((c + (decimal)d).GetType());

            Console.ReadKey();
        }
    }
}
