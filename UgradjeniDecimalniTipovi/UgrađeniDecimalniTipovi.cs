using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;
            
            Console.WriteLine("{0:F2}",f1);
            Console.WriteLine("{0:F2}", f1 - f2);
            Console.WriteLine("{0:F2}", f1 - f3);

            // Primjer binarnog zaokruživanja na rezultat
            double trecina1 = 1.0 / 3;
            double trecina2 = 1 - 2.0 / 3;
            Console.WriteLine("{0:F2}", trecina1);
            Console.WriteLine("{0:F2}", trecina2);
            Console.WriteLine("{0:F2}", trecina1-trecina2);

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            double najveci = double.MaxValue;
            najveci *= 2;
            Console.WriteLine(2 * najveci);

            // Primjeri neodređenih rezultata dijeljenja
            double a = 10;
            a /= 0.0;
            Console.WriteLine(a);

            double nula = 0.0;
            nula /= 0.0;
            Console.WriteLine(nula);



            double pet = 5;

            int c = (int)pet;
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
