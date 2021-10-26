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
            Console.WriteLine("Max value for double: " + double.MaxValue.ToString());
            Console.WriteLine("Min value for double: {0}", double.MinValue.ToString());
            Console.WriteLine("Max value for float: " + float.MaxValue.ToString());
            Console.WriteLine("Min value for float: {0}", float.MinValue.ToString());
            Console.WriteLine("Max value for dec: " + decimal.MaxValue.ToString());
            Console.WriteLine("Min value for dec: {0}", decimal.MinValue.ToString());
            Console.WriteLine();
            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // 031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;

            // 032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("f1 - f2 = {0}", (f1-f2).ToString());
            Console.WriteLine("f1 - f3 = {0}", (f1 - f3).ToString());

            // Primjer binarnog zaokruživanja na rezultat
            // 033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1 = 1 / 3;
            double trećina2 = 1 - 2 / 3;
            Console.WriteLine("trećina1 = {0}", trećina1);
            Console.WriteLine("trećina2 = {0}", trećina2);
            Console.WriteLine("delta = {0}", (trećina1-trećina2).ToString());

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // 034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            Console.WriteLine("double.MaxValue * 2 = {0}", (double.MaxValue *2).ToString());
            Console.WriteLine("double.MinValue * 2 = {0}", (double.MinValue/2).ToString());

            // Primjeri neodređenih rezultata dijeljenja
            // 035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double poz = 123;
            double neg = -123;
            Console.WriteLine("123 / 0 = {0}", (poz/0).ToString());
            Console.WriteLine("-123 / 0 = {0}", (neg / 0).ToString());

            // 036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double dupli = 10000;
            Console.WriteLine("double 10000 / 0 = {0}", (dupli / 0).ToString());

            // 037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double brojka = 5;
            // 038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int cijeli = 5;
            Console.WriteLine("Cijeli = " + cijeli);

            Console.ReadKey();
        }
    }
}
