﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 030 Ispisati granične vrijednosti za tipove double, float i decimal.
            Console.WriteLine($"Minimalna vrijednost za double: {double.MinValue}  Maksimalna vrijednost za double: {double.MaxValue}");
            Console.WriteLine($"Minimalna vrijednost za float: {float.MinValue}  Maksimalna vrijednost za float: {float.MaxValue}");
            Console.WriteLine($"Minimalna vrijednost za decimal: {decimal.MinValue}  Maksimalna vrijednost za decimal: {decimal.MaxValue}");
            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // 031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;
            // 032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("Razlika (f1-f2): " + string.Format("{0:f2}", f1 - f2));
            Console.WriteLine("Razlika (f1-f3): " + string.Format("{0:f2}", f1 - f3));
            // Primjer binarnog zaokruživanja na rezultat
            // 033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1 = 1 / 3;
            double trećina2 = 1 - 2 / 3;
            // Za slucaj da baš mora biti double (bez da se slijepo prati tekst zadatka)
            // double trećina1 = 1.0 / 3;
            // double trećina2 = 1 - 2.0 / 3
            Console.WriteLine($"trećina1: {trećina1}");
            Console.WriteLine($"trećina2: {trećina2}");
            Console.WriteLine($"trećina1 - trećina1: {trećina1 - trećina1}");
            Console.WriteLine($"trećina1 - trećina2: {trećina1 - trećina2}");
            
            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // 034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double doubleMax = double.MaxValue;
            double doubleMin = double.MinValue;
            Console.WriteLine($"doubleMax * 2: {doubleMax * 2}");
            Console.WriteLine($"doubleMin * 2: {doubleMin * 2}");
            // Primjeri neodređenih rezultata dijeljenja
            // 035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double broj = 9.99;
            Console.WriteLine($"Dijeljenje poz vrijednosti double broja s 0: {broj / 0}");
            Console.WriteLine($"Dijeljenje neg vrijednosti double broja s 0: {-broj / 0}");
            // 036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double broj2 = 0;
            Console.WriteLine($"Dijeljenje double broja 0 s 0: {broj2 / 0}");
            // 037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double broj3 = 5;
            // 038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int broj4 = (int) broj3;
            Console.WriteLine($"broj4: {broj4}");
            Console.ReadKey();
        }
    }
}
