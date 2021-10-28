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
            /*string[] list;
            list = new string[] { "double", "float", "decimal"};
            for (int i = 0; i < 3; i++) {
                Console.WriteLine(list[i].MaxValue);
                Console.WriteLine(list[i].MinValue);
                }*/
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
           
            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            float f1, f2, f3;
            f1 = 1234567890F;
            f2 = 1234567990F;
            f3 = 9F;
            // Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            float delta1, delta2;
            delta1 = f1 - f2;
            delta2 = f1 - f3;
            Console.WriteLine(String.Format("{0:F2}", delta1));
            Console.WriteLine(String.Format("{0:F2}", delta2));
            
            // Primjer binarnog zaokruživanja na rezultat
            // Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            double trećina1, trećina2, delta3, delta4;
            trećina1 = 1.0 / 3;
            trećina2 = 1 - 2 / 3.0;
            Console.WriteLine(trećina1);
            Console.WriteLine(trećina2);
            delta3 = trećina1 - trećina1;
            delta4 = trećina1 - trećina2;
            //Console.WriteLine(String.Format("{0:F2}", delta3));
            //Console.WriteLine(String.Format("{0:F2}", delta4));
            Console.WriteLine(delta3);
            Console.WriteLine(delta4);

            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double max = double.MaxValue;
            Console.WriteLine(max*2);
            double min = double.MinValue;
            Console.WriteLine(min*2);

            // Primjeri neodređenih rezultata dijeljenja
            // Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double try1, try2, try3, poz = 111, neg = -111, joj=0;
            try1 = poz / 0;
            try2 = neg / 0;
            Console.WriteLine(try1);
            Console.WriteLine(try2);
            // Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            try3 = joj / 0;
            Console.WriteLine(try3);
            // Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double proba;
            proba = 5;
            // Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            int zmaj;
            zmaj = (int)proba;
            Console.WriteLine(zmaj);
            Console.ReadKey();
        }
    }
}
