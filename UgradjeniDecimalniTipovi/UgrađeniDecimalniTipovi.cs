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

            // TODO:036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double nula = 0.0;
            nula /= 0.0;
            Console.WriteLine(nula);


            // TODO:037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.

            double pet = 5;

            // TODO:038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int c = (int)pet;
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
