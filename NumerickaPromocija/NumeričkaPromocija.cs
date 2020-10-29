﻿using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            //  Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 10;
            int b = 3;
            Console.WriteLine(a / b);
            // Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine((double)a / b);

            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int najveći = int.MaxValue;
            long dugi = 1;
            Console.WriteLine(najveći);
            Console.WriteLine(dugi);
            Console.WriteLine(najveći + dugi);
            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double c = 3.14;
            int d = 4;
            Console.WriteLine(c + d);
            Console.WriteLine(c / d);

            // Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal dec = 3.14M;
            Console.WriteLine(dec + (decimal)c);
            Console.ReadKey();
        }
    }
}
