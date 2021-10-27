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
            Console.WriteLine($"Granicna vrijednosti:\n- double: ({double.MinValue}, {double.MaxValue})\n- float: ({float.MinValue}, {float.MaxValue})\n- decimal: ({decimal.MinValue}, {decimal.MaxValue})");

            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // :031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            var f1 = 1234567890f;
            var f2 = 1234567990f;
            var f3 = 9f;
            // :032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine($"{f1 - f2:F2}");
            Console.WriteLine($"{f1 - f3:F2}");
            // Primjer binarnog zaokruživanja na rezultat
            // :033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            var trecina1 = 1 / 3d;
            var trecina2 = 1 - 2 / 3d;
            Console.WriteLine(trecina1 - trecina2);
            Console.WriteLine(trecina2 - trecina1);

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // :034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            var mult = double.MaxValue;
            Console.WriteLine(mult * 2);
            Console.WriteLine(double.MinValue * 2);

            // Primjeri neodređenih rezultata dijeljenja
            // :035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            Console.WriteLine($"Djeljenje pozitivnog double broja s 0: {5d/0}");
            Console.WriteLine($"Djeljenje negativnog double broja s 0: {-5d/0}");

            // :036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            Console.WriteLine($"Double 0/double 0: {0d/0d}");

            // :037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            var d_var = 5d;

            // :038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            //int i_var = d_var;
            // ne moze se implicitno konvertirati int u double
            // ovo bi radilo: int i_var = (int)d_var

            Console.ReadKey();
        }
    }
}
