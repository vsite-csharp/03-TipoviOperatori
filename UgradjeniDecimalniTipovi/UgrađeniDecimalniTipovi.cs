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
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(decimal.MinValue);
            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // 031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;
            // 032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("{0:F2}",f1 - f2);
            Console.WriteLine("{0:F2}", f1 - f3);

            // Primjer binarnog zaokruživanja na rezultat
            // 033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trecina1=1/3;
            double trecina2=1-(2/3);
            Console.WriteLine(trecina1);
            Console.WriteLine(trecina2);
            Console.WriteLine(trecina1-trecina1);
            Console.WriteLine(trecina1-trecina2);

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // 034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double vari = (double.MaxValue) * 2;
            double vari2 = (double.MinValue) * 2;
            // Primjeri neodređenih rezultata dijeljenja
            // 035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            //double poz = 465468 / 0;
            //double neg = -46876154 / 0;
            // Javit ce gresku Division by constant zero
            // 036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double vari3 = 0;
            double vari4 = vari3 / 0;
            // 037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double vari5 = 5;
            // 038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            //int vari6 = vari5;
            // Javlja error da se nemoze prebacit double u int i da treba castanje
            //Console.WriteLine(vari6);
            Console.ReadKey();
        }
    }
}
