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
            // :030 Ispisati granične vrijednosti za tipove double, float i decimal.
            double d = double.MaxValue;
            float f = float.MaxValue;
            decimal dc = decimal.MaxValue;
            Console.WriteLine("Max double: {0}", d);
            Console.WriteLine("Max float: {0}", f);
            Console.WriteLine("Max decimal: {0}", dc);
            d = double.MinValue;
            f = float.MinValue;
            dc = decimal.MinValue;
            Console.WriteLine("Min double: {0}", d);
            Console.WriteLine("Min float: {0}", f);
            Console.WriteLine("Min decimal: {0}", dc);

            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // :031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;

            // :032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("{0:F2}", f1 -f2);
            Console.WriteLine("{0:F2}", f1 -f3);

            // Primjer binarnog zaokruživanja na rezultat
            // :033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-trećina2).
            double trećina1 = 1 / 3;
            double trećina2 = 1 - 2 / 3;
            Console.WriteLine(trećina1);
            Console.WriteLine(trećina2);
            Console.WriteLine(trećina1 - trećina1);
            Console.WriteLine(trećina1 - trećina2);

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // :034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            Console.WriteLine(dmax*2);
            Console.WriteLine(dmin*2);

            // Primjeri neodređenih rezultata dijeljenja
            // :035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double poz = 10;
            double neg = -10;
            Console.WriteLine(poz/0);
            Console.WriteLine(neg/0);

            // :036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double nula = 0;
            Console.WriteLine(nula/0);

            // :037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double pet = 5;

            // :038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int i = (int)pet;
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
