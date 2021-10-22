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
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            decimal maxDecimal = decimal.MaxValue;
            decimal minDecimal = decimal.MinValue;

            Console.WriteLine($"DOUBLE: Maximum value -> {maxDouble}, Minimum value -> {minDouble}");
            Console.WriteLine($"FLOAT: Maximum value -> {maxFloat}, Minimum value -> {minFloat}");
            Console.WriteLine($"DECIMAL: Maximum value -> {maxDecimal}, Minimum value -> {minDecimal}\n");
            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;
            // Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine($"First subtraction: {f1 - f2:F2}");
            Console.WriteLine($"Second subtraction: {f1 - f3:F2}\n");
            // Primjer binarnog zaokruživanja na rezultat
            // Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1 = 1/3;
            double trećina2 = 1 - 2/3;
            Console.WriteLine($"trećina1 = {trećina1}, trećina2 = {trećina2}");
            Console.WriteLine($"First subtraction: {trećina1 - trećina1}");
            Console.WriteLine($"Second subtraction: {trećina1 - trećina2}\n");
            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"Results of division by 2: {max}/2 = {max / 2}, {min}/2 = {min / 2}");
            // Primjeri neodređenih rezultata dijeljenja
            // Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double positiveNumber = 5;
            double negativeNumber = -5;
            Console.WriteLine($"Results of division by 0: {positiveNumber}/0 = {positiveNumber / 0}, {negativeNumber}/0 = {negativeNumber / 0}\n");
            // Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double zero = new double();
            Console.WriteLine($"Results of division by 0: {zero}/0 = {zero / 0}\n");
            // Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double five = 5;
            // Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            //int intFive = five;
            int intFive = (int)five;
            Console.WriteLine($"Double value assigned explicitly to integer: {five} -> {intFive}");
            Console.ReadKey();
        }
    }
}
