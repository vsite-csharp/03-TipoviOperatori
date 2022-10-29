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
            Console.WriteLine("----- double -----");
            Console.WriteLine("Epsilon = {0}", double.Epsilon);
            Console.WriteLine("Max = {0}\nMin = {1}", double.MaxValue, double.MinValue);
            Console.WriteLine("----- float ----");
            Console.WriteLine("Epsilon = {0}", float.Epsilon);
            Console.WriteLine("Max = {0}\nMin = {1}", float.MaxValue, float.MinValue);
            Console.WriteLine("----- decimal -----");
            Console.WriteLine("Max = {0}\nMin = {1}", decimal.MaxValue, decimal.MinValue);


            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            // Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine($"{(f1 - f2):F0}");
            Console.WriteLine($"{(f1 - f3):F0}");
            // Primjer binarnog zaokruživanja na rezultat:L
            // Definirati dvije varijable: trećina1 i trećina2, tipa double s vrijednostima koje se izračunavaju pomoću izraza 1/3, odn. (1-2/3). Voditi računa da dijeljenje u tim izrazima ne bude cjelobrojno!
            double third1 = (double)1 / 3;
            double third2 = 1 - 2.0 / 3;
            Console.WriteLine($"third1 = {third1}");
            Console.WriteLine($"third2 = {third2}");
            // TODO:034 Ispisati vrijednosti varijabli trećina1 i trećina2 te njihove razlike (trećina1-trećina1), odn. (trećina1-tećina2).

            // Primjer utjecaja ograničenog raspona na rezultat množenja i dijeljenja:
            // TODO:035 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.

            // Primjeri neodređenih rezultata dijeljenja:
            // TODO:036 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.

            // TODO:037 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.

            // TODO:038 Definirati varijablu tipa double i pridružiti joj vrijednost 5.

            // TODO:039 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.

            Console.ReadKey();
        }
    }
}
