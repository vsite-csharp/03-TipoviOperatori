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
            Console.WriteLine("double min i max\n");
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine("float min i max\n");
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine("decimal min i max\n");
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // 031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;
            // 032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("f1-f2={ 0:F2}", f1 - f2);
            Console.WriteLine("f1-f2={ 0:F2}", f1 - f3);
            // Primjer binarnog zaokruživanja na rezultat
            // 033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trecina1 = 1 / 3;
            double trecina2 = (1 - 2 / 3);
            Console.WriteLine("trecina1 - t1\n");
            Console.WriteLine(trecina1 - trecina1);
            Console.WriteLine("trecina1 - t2\n");
            Console.WriteLine(trecina1 - trecina2);
            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // 034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double d = double.MaxValue;
            Console.WriteLine("double max x 2\n");
            Console.WriteLine(d * 2);
            double m = double.MinValue;
            Console.WriteLine("double min x 2\n");
            Console.WriteLine(m * 2);
            // Primjeri neodređenih rezultata dijeljenja
            // 035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double p = 4;
            double n = -4;
            Console.WriteLine("double pozitivan dijelim s nulom:\n");
            Console.WriteLine(p / 0);
            Console.WriteLine("double negativan dijelim s nulom:\n");
            Console.WriteLine(n / 0);
            // 036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double zero = 0;
            Console.WriteLine(zero / 0);
            // 037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double var;
            var = 5;
            // 038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int intic = (int)var;
            Console.WriteLine(intic);
            Console.ReadKey();
        }
    }
}
