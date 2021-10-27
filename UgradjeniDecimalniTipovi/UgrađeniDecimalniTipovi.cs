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
            Console.WriteLine("Granična vrijednost za double je {0}, za float je {1}, a za decimal je {2}!\n", double.MaxValue, float.MaxValue, decimal.MaxValue);
            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // 031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890F;
            float f2 = 1234567990F;
            float f3 = 9F;
            // 032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("f1 - f2 = {0:F2} - {1:F2} = {2:F2}", f1, f2, f1 - f2);
            Console.WriteLine("f1 - f3 = {0:F2} - {1:F2} = {2:F2}\n", f1, f3, f1 - f3);

            // Primjer binarnog zaokruživanja na rezultat
            // 033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1 = 1/3;
            double trećina2 = 1-2/3;

            Console.WriteLine("trećina1 ima tip{0}", trećina1.GetType());
            Console.WriteLine("trećina1 = {0}, trećina2 = {1}", trećina1, trećina2);
            Console.WriteLine("trećina1 - trećina1 = {0}", trećina1 - trećina1);
            Console.WriteLine("trećina1 - trećina2 = {0}\n", trećina1 - trećina2);

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // 034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double prva = double.MaxValue;
            double druga = double.MinValue;
            Console.WriteLine("prva * 2 = {0}", prva * 2);
            Console.WriteLine("druga * 2 = {0}\n", druga * 2);

            // Primjeri neodređenih rezultata dijeljenja
            // 035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double pozitivni = 6;
            double negativni = -8;
            Console.WriteLine("pozitivni double / 0 = {0}", pozitivni / 0);
            Console.WriteLine("negativni double / 0 = {0}\n", negativni / 0);

            // 036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double nula = 0;
            Console.WriteLine("nula / 0 = {0}\n", nula / 0);

            // 037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double petica = 5;

            // 038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int nekiDrugi = 61;
            Console.WriteLine("int + double = {0}\n", nekiDrugi + petica);

            Console.ReadKey();
        }
    }
}
