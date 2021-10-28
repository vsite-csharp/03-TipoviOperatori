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
            double doubleMin = double.MinValue;
            double doubleMax = double.MaxValue;
            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;
            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;

            Console.WriteLine( "Double range: [{0}, {1}]", doubleMin, doubleMax );
            Console.WriteLine( "Float range: [{0}, {1}]", floatMin, floatMax );
            Console.WriteLine( "Decimal range: [{0}, {1}]", decimalMin, decimalMax );

            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890F;
            float f2 = 1234567990F;
            float f3 = 9F;

            // Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("f1 - f2 = {0:F2}", f1-f2); // ispisuje 0 umjesto -100
            Console.WriteLine("f1 - f3 = {0:F2}", f1-f3); // ispisuje 1234567800 umjesto 1234567881

            // Primjer binarnog zaokruživanja na rezultat
            // Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1 = 1.0 / 3;
            double trećina2 = 1 - 2.0 / 3;
            Console.WriteLine( "1/3 = {0}.", trećina1); 
            Console.WriteLine( "1 - 2/3 = {0}.", trećina2);
            Console.WriteLine( "1/3 - 1/3 = {0}.", trećina1-trećina1); //0
            Console.WriteLine( "1/3 - (1-2/3) = {0}.", trećina1-trećina2); //-5.551111512312578E-17

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            Console.WriteLine($"doubleMax * 2 = {doubleMax*2}"); //?
            Console.WriteLine($"doubleMin * 2 = {doubleMin*2}"); //-?

            // Primjeri neodređenih rezultata dijeljenja
            // Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double poz = 5d / 0;
            double neg = -5d / 0;
            Console.WriteLine($"Dijeljenje s nulom\nPozitivni broj: {poz}\nNegativni broj: {neg}"); //? i -?

            // Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double nula = 0d;
            Console.WriteLine($"Nula kroz nula je {nula/0}"); //NaN

            // Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double pet = 5;

            // Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int petInt = (int)pet;
            Console.WriteLine($"Broj pet {petInt}");

            Console.ReadKey();
        }
    }
}
