﻿using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            nulabilniDuplić = null;

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            // običniDuplić = nulabilniDuplić;
            nulabilniDuplić = 10;

            nulabilniDuplić = običniDuplić;




            Console.ReadKey();
        }
    }
}
