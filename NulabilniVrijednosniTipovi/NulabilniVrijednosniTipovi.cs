﻿using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            // 050  Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.
            nulabilniDuplić = null;
            Console.WriteLine($"nulabilniDuplić: {nulabilniDuplić}");
            // 051 Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.
            // Error: Cannot implicitly convert type 'double?' to 'double'
            //običniDuplić = nulabilniDuplić;
            // 052 Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.
            nulabilniDuplić = 2.1;
            Console.WriteLine($"nulabilniDuplić nakon postavljanja vrijedonsti: {nulabilniDuplić}");
            // 053 Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.
            // Error: Cannot implicitly convert type 'double?' to 'double'
            //običniDuplić = nulabilniDuplić;
            Console.ReadKey();
        }
    }
}
