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
            Console.WriteLine("Float MAX: " + float.MaxValue);
            Console.WriteLine("Float MIN: " + float.MinValue);
            Console.WriteLine("Double MAX: " + double.MaxValue);
            Console.WriteLine("Double MIN: " + double.MinValue);
            Console.WriteLine("Decimal MAX: " + decimal.MaxValue);
            Console.WriteLine("Decimal MIN: " + decimal.MinValue);
            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // 031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;
            // 032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine($"f1: {f1}");
            Console.WriteLine($"f2: {f2}");
            Console.WriteLine($"f3: {f3}");
            Console.WriteLine($"f1 - f2: {(f1 - f2):F2}");
            Console.WriteLine($"f1 - f3: {(f1 - f3):F2}");
            // Primjer binarnog zaokruživanja na rezultat
            // 033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1 = 1.0 / 3.0;
            double trećina2 = 1.0 - 2.0 / 3.0;
            Console.WriteLine($"trećina1: {trećina1}");
            Console.WriteLine($"trećina2: {trećina2}");
            Console.WriteLine($"trećina1 - trećina1: {trećina1 - trećina1}");
            Console.WriteLine($"trećina1 - trećina2: {trećina1 - trećina2}");
            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // 034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double d_max = double.MaxValue;
            double d_min = double.MinValue;
            Console.WriteLine($"d_max * 2: {d_max * 2}");
            Console.WriteLine($"d_min * 2: {d_min * 2}");
            // Primjeri neodređenih rezultata dijeljenja
            // 035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double a = 5.63;
            Console.WriteLine($"a / 0: {a / 0}");
            Console.WriteLine($"-a / 0: {-a / 0}");
            // 036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double b = 0;
            Console.WriteLine($"b / 0: {b / 0}");
            // 037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double c = 5;
            // 038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int d = (int)c;
            Console.WriteLine($"d = {c}");
            Console.ReadKey();
        }
    }
}
