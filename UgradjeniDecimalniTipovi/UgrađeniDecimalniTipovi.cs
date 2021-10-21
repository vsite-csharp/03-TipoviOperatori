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
            Console.WriteLine(Double.MaxValue);
            Console.WriteLine(Double.MinValue);
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
            Console.WriteLine($"f1 - f2 = {0:F2}", (f1 - f2));
            Console.WriteLine($"f1 - f3 = {0:F2}", (f1 - f3));
            // Primjer binarnog zaokruživanja na rezultat
            // Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1 = 1 / 3;
            double trećina2 = (1 - 2 / 3);
            Console.WriteLine(trećina1 - trećina1);
            Console.WriteLine(trećina1 - trećina2);
            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double d1 = double.MaxValue;
            Console.WriteLine($"{d1*2}");
            double d2 = double.MinValue;
            Console.WriteLine($"{d2 * 2}");
            // Primjeri neodređenih rezultata dijeljenja
            //Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double d3 = 4d;
            Console.WriteLine(d3/0d);
            double d4 = -4d;
            Console.WriteLine(d4/0d);
            // Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double d5 = 0d;
            Console.WriteLine(d5 / 0d);
            // Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double d6 = 5d;
            // Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int i8 = (int)d6;
            Console.WriteLine(i8);

            Console.ReadKey();
        }
    }
}
