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
            // Ispisati granične vrijednosti za tipove double, float i decimal.
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;

            // Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("{0:F2}", f1);
            Console.WriteLine("{0:F2}", f1 - f2);
            Console.WriteLine("{0:F2}", f1 - f3);

            // Primjer binarnog zaokruživanja na rezultat
            // Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1 = 1.0 / 3;
            double trećina2 = 1 - 2.0 / 3;
            Console.WriteLine("{0:F20}", trećina1);
            Console.WriteLine("{0:F20}", trećina2);
            Console.WriteLine("{0:F20}", trećina1 - trećina2);

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double najveći = double.MaxValue;
            najveći *= 2;
            Console.WriteLine(najveći);
            // Primjeri neodređenih rezultata dijeljenja
            // Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double a = 10;
            a /= 0.0;
            Console.WriteLine(a);
            // Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double nula = 0.0;
            nula /= 0.0;
            Console.WriteLine(nula);
            // Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double pet = 5;
            // Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int c = (int)pet;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
