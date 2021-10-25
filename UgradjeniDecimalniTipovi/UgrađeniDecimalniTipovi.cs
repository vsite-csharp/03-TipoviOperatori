using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 030 Ispisati granične vrijednosti za tipove double, float i decimal.

            Console.WriteLine("Double max value : " + double.MaxValue); 
            Console.WriteLine("Float max value : " + float.MaxValue); 
            Console.WriteLine("Decimal max value : " + decimal.MaxValue); 
            Console.WriteLine("Double min value : " + double.MinValue); 
            Console.WriteLine("Float min value : " + float.MinValue); 
            Console.WriteLine("Decimal min value : " + decimal.MinValue);



            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // 031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.

            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;

            // 032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine(f1 + " " + f2 + " " + f3); 
            Console.WriteLine($"(f1-f2) = {0:F2}", f1 - f2); 
            Console.WriteLine($"(f1-f3) = {0:F2}", f1 - f3);
            // It is not correct 

            // Primjer binarnog zaokruživanja na rezultat
            // 033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).

            double trecina = 1 / 3;
            double trecina2 = (1 - 2 / 3);

            Console.WriteLine(trecina - trecina); //0
            Console.WriteLine(trecina - trecina2); // -1
            Console.WriteLine(trecina +" "+ trecina2);  //0, -1  it is not correct 

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // 034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.

            double maxDouble = double.MaxValue;
            Console.WriteLine("MaxDouble " + maxDouble + " MaxDouble * 2  " + maxDouble * 2);
            double minDouble = double.MinValue;
            Console.WriteLine("MinDouble * 2 " + minDouble * 2); 

            // Primjeri neodređenih rezultata dijeljenja
            // 035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.

            double positive = 1.2;
            double negative = -1.2;
            Console.WriteLine(positive / 0); // ?
            Console.WriteLine(negative / 0); // ?

            // 036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.

            double positive2 =0;
            Console.WriteLine(positive2 / 0); // NaN


            // 037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.

            double five = 5;

            // 038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.

            //int fiveInt = five;  It is not possible to convert it from double to integer except using cast 
            int fiveInt = (int)five;
            Console.WriteLine(fiveInt);

            Console.ReadKey();
        }
    }
}
