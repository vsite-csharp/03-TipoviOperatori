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
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.Epsilon);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.Epsilon);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // TODO:031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;

            // TODO:032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine(f1 - f2);
            Console.WriteLine((f1 - f2).ToString("F0"));
            Console.WriteLine($"{(f1 - f2):F0}");
            Console.WriteLine(f1 - f3);
            Console.WriteLine($"{(f1 - f3):F0}");
            Console.WriteLine((f1 - f3).ToString("F0"));

            // Primjer binarnog zaokruživanja na rezultat:
            // TODO:033 Definirati dvije varijable: trećina1 i trećina2, tipa double s vrijednostima koje se izračunavaju pomoću izraza 1/3, odn. (1-2/3). Voditi računa da dijeljenje u tim izrazima ne bude cjelobrojno!
            double trećina1 = 1.0 / 3;
            double trećina2 = 1 - 2.0 / 3;
            // TODO:034 Ispisati vrijednosti varijabli trećina1 i trećina2 te njihove razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            Console.WriteLine(trećina1);
            Console.WriteLine(trećina2);
            Console.WriteLine(trećina1 - trećina2);
            Console.WriteLine(trećina2 - trećina1);
            // Primjer utjecaja ograničenog raspona na rezultat množenja i dijeljenja:
            // TODO:035 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double maxDouble = double.MaxValue;
            Console.WriteLine(maxDouble * 2);
            double minDouble = double.MinValue;
            Console.WriteLine(minDouble * 2);
            // Primjeri neodređenih rezultata dijeljenja:
            // TODO:036 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            Console.WriteLine(maxDouble / 0);
            Console.WriteLine(minDouble / 0);
            // TODO:037 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            Console.WriteLine(0.0 / 0);

            // TODO:038 Definirati varijablu tipa double i pridružiti joj vrijednost 5.

            // TODO:039 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.

            Console.ReadKey();
        }
    }
}
