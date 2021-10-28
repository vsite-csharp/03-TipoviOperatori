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
            // 030 Ispisati granične vrijednosti za tipove double, float i decimal.

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MinValue);

            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // 031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.

            float f1 = 1234567890f;
            float f2 = 1234567990f;
            float f3 = 9f;


            //032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("f1 - f2 = {0:F2} - {1:F2} = {2:F2}", f1, f2, f1 - f2);
            Console.WriteLine("f1 - f3 = {0:F2} - {1:F2} = {2:F2}", f1, f3, f1 - f3);

            // Primjer binarnog zaokruživanja na rezultat
            // 033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).

            double trecina1 = 1.0 / 3;
            double trecina2 = 1 - 2 / 3.0;

            Console.WriteLine("trecina1 = {0}, trecina2 = {1}", trecina1, trecina2);
            Console.WriteLine("trecina1 - trecina1 = {0}", trecina1 - trecina1);
            Console.WriteLine("trecina1 - trecina2 = {0}", trecina1 - trecina2);


            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // 034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double dmax = double.MaxValue;
            double dmin = double.MinValue;

            Console.WriteLine("dmax * 2 = {0}", dmax*2);
            Console.WriteLine("dmin * 2 = {0}", dmin*2);

            // Primjeri neodređenih rezultata dijeljenja
            // 035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.

            double d1 = 123.321;
            double d2 = -123.321;
            Console.WriteLine(d1 / 0);
            Console.WriteLine(d2 / 0);


            // 036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.

            double d = 0;
            Console.WriteLine(d / 0);

            // 037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.

            d = 5;

            // 038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.

            int i = 0;
            i = (int)d;
            Console.WriteLine("d = {0}", d);
            Console.WriteLine("i = {0}", i);

            Console.ReadKey();
        }
    }
}
