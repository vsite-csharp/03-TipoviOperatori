﻿using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent. Dijeljitelj i dijeljenik odabrati tako da dijeljenje bude s ostatkom.
            int a = 5;
            int b = 10;
            Console.WriteLine(a/b);
            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double d = 3.14;
            Console.WriteLine(a + d);
            a = (int)(a + d);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
