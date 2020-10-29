using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // TODO:030 Ispisati granične vrijednosti za tipove double, float i decimal.
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
            Console.WriteLine(f1);
            Console.WriteLine("{0:F2}", f1 - f2);
            Console.WriteLine("{0:F2}", f1 - f3);

            // Primjer binarnog zaokruživanja na rezultat
            double trecina1 = 1.0 / 3;
            double trecina2 = 1 - 2.0 / 3;
            Console.WriteLine("{0:F20}", trecina1);
            Console.WriteLine("{0:F20}", trecina2);
            Console.WriteLine(trecina1 - trecina2);

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // TODO:034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double najveci = double.MaxValue;
            najveci *= 2;
            Console.WriteLine(najveci);

            double najmanji = double.MinValue;
            najmanji *= 2;
            Console.WriteLine(najmanji);
            // Primjeri neodređenih rezultata dijeljenja
            double a = 10;
            Console.WriteLine(a / 0.0);
            double nula = 0.0;
            nula /= 0.0;
            Console.WriteLine(nula);
            double dbl = 5;
            Console.WriteLine(dbl);
            int c = (int)dbl;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
