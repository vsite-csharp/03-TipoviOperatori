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
            // OK-TODO:030 Ispisati granične vrijednosti za tipove double, float i decimal.
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // OK-TODO:031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;

            // OK-TODO:032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine($"f1 - f2 = {0:F2}", (f1 - f2));
            Console.WriteLine($"f1 - f3 = {0:F2}", (f1 - f3));

            // Primjer binarnog zaokruživanja na rezultat
            // OK-TODO:033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1 = 1.0 / 3;
            double trećina2 = 1 - 2 / 3.0;
            Console.WriteLine(trećina1);
            Console.WriteLine(trećina2);
            Console.WriteLine(trećina1 - trećina2);

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // OK-TODO:034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double var1 = double.MaxValue;
            Console.WriteLine(var1 * 2);

            double var2 = double.MinValue;
            Console.WriteLine(var2 * 2);

            // Primjeri neodređenih rezultata dijeljenja
            // OK-TODO:035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            Console.WriteLine((double)9 / 0);
            Console.WriteLine((double)-9 / 0);

            // OK-TODO:036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            Console.WriteLine((double)0 / 0);

            // OK-TODO:037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double var = 5;

            // OK-TODO:038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            double var11 = (int)var;
            Console.Write(var11);

            Console.ReadKey();
        }
    }
}
