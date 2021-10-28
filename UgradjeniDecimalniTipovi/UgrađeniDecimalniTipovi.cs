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
            //030 Ispisati granične vrijednosti za tipove double, float i decimal.
            Console.WriteLine("Float max = {0}", float.MaxValue);// 3.402823E+38
            Console.WriteLine("Double max ={0}", double.MaxValue);//1.79769313486232E+308
            Console.WriteLine("Decimal max = {0}", decimal.MaxValue);// 79228162514264337593543950335

            Console.WriteLine("Float min = {0}", float.MinValue);//-3.402823E+38
            Console.WriteLine("Double min = {0}", double.MinValue);//-1.79769313486232E+308
            Console.WriteLine("Decimal min = {0}", decimal.MinValue);// -79228162514264337593543950335
            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // 031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;

            //032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("(f1-f2) = {0:F2}", f1 - f2);// 0.00
            Console.WriteLine("(f1-f3) = {0:F2}", f1 - f3);// 1234568000.00

            // Primjer binarnog zaokruživanja na rezultat
            // 033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1 = 1.0/ 3;
            double trećina2 = (1 - 2) / 3.0;
            Console.WriteLine("trećina1 - trećina2 = {0}", trećina1- trećina2);//0
            Console.WriteLine("trećina2 - trećina1 = {0}", trećina2 - trećina1);//0
            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // TODO:034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double var1 = double.MaxValue;
            Console.WriteLine("{0}", var1*2);//∞

            double var2 = double.MinValue;
            Console.WriteLine("{0}", var2 * 2);//-∞
            // Primjeri neodređenih rezultata dijeljenja
            // 035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double a = 5.5;
            Console.WriteLine("double/0 = {0}",a/0);//∞

            double b = -5.5;
            Console.WriteLine("-double/0 = {0}", b / 0);//-∞
            // 036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double c = 0;
            Console.WriteLine("0/0 = {0}", c / 0); //NaN
            // 037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.

            double d = 5;
            // TODO:038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int e = (int)d;
            Console.WriteLine("{0}", e);//5
            Console.ReadKey(false);
        }
    }
}
