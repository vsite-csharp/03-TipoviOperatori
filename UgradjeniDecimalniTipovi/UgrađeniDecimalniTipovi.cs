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
            Console.WriteLine("\n");
            Console.WriteLine("Double MIN vrijednost {0}", double.MinValue);
            Console.WriteLine("Double MAX vrijednost {0}", double.MaxValue);

            Console.WriteLine("Float MIN vrijednost {0}", float.MinValue);
            Console.WriteLine("Float MAX vrijednost {0}", float.MaxValue);

            Console.WriteLine("Decimal MIN vrijednost {0}", decimal.MinValue);
            Console.WriteLine("Decimal MAX vrijednost {0}", decimal.MaxValue);

            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // 031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.
            Console.WriteLine("\n");
            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;

            // 032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine("\n");
            Console.WriteLine("f1 = {0}", f1);
            Console.WriteLine("f2 = {0}", f2);
            Console.WriteLine("f3 = {0}", f3);

            Console.WriteLine("Razlika f1 - f2 = {0:F2} ", (f1 - f2)); //ispadne 0,00 umjesto -100
            Console.WriteLine("Razlika f1 - f3 = {0:F2} ", (f1 - f3)); //ispadne 12345678000,00 umjesto 1234567881

            // Primjer binarnog zaokruživanja na rezultat
            // 033 Definirati dvije varijable trećina1 i trećina2 tipa double s vrijednostima 1/3, odn. (1-2/3). Ispisati njihove vrijednosti te razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            Console.WriteLine("\n");
            double trećina1 = 1.0/3; //prvo dijeli cjelobrojne brojeve, pa tu 0 pridruzuje double tipu, zato trebamo staviti 1.0 umjesto 1
            double trećina2 = (1 - 2/3.0);

            Console.WriteLine("trećina1 = {0}", trećina1);
            Console.WriteLine("trećina2 = {0}", trećina2);

            Console.WriteLine("Razlika trećina1 - trećina1 = {0} ", (trećina1 - trećina1)); //ispadne 0
            Console.WriteLine("Razlika trećina1 - trećina2 = {0} ", (trećina1 - trećina2)); //ispadne -1
            
            // Primjer utjecaja ograničenog raspona na rezultat množenja/dijeljenja
            // 034 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            Console.WriteLine("\n");
            double doubleMax = double.MaxValue;
            Console.WriteLine("DoubleMax * 2 = ", doubleMax*2); //nista se ne ispisuje

            double doubleMin = double.MinValue;
            Console.WriteLine("DoubleMin * 2 = ", doubleMin*2); //nista se ne ispisuje

            // Primjeri neodređenih rezultata dijeljenja
            // 035 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            Console.WriteLine("\n");
            double pozBroj = 100;
            double negBroj = -100;

            Console.WriteLine("{0} / 0 = {1}", pozBroj, (pozBroj/0)); // ispisuje se ?
            Console.WriteLine("{0} / 0 = {1}", negBroj, (negBroj/0)); // ispisuje se -?

            // 036 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            Console.WriteLine("\n");
            double nula = 0;
            Console.WriteLine("0 / 0 = {0}", nula); //0

            // 037 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            Console.WriteLine("\n");
            double var1 = 5;

            // 038 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            Console.WriteLine("\n");
            int var2 = (int)var1;
            Console.WriteLine("var2 = {0}", var2);
            
            Console.ReadKey();
        }
    }
}
