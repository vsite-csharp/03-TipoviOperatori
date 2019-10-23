namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            // TODO:030 Ispisati granične vrijednosti za tipove double, float i decimal.
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);            
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            // Primjer utjecaja ograničene preciznosti na rezultat oduzimanja/zbrajanja
            // :031 Definirati tri varijable f1, f2 i f3 tipa float s vrijednostima: 1234567890, 1234567990 i 9.

            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;
            // :032 Ispisati razlike (f1-f2), odn. (f1-f3) (pomoću formata "{0:F2}" osigurati ispis svih znamenki) i provjeriti točnost ispisa.
            Console.WriteLine($"{f1-f2:F5}");
            Console.WriteLine(f1-f3);
            // Primjer binarnog zaokruživanja na rezultat:
            // :033 Definirati dvije varijable: trećina1 i trećina2, tipa double s vrijednostima koje se izračunavaju pomoću izraza 1/3, odn. (1-2/3). Voditi računa da dijeljenje u tim izrazima ne bude cjelobrojno!
            double trecina1 = 1 / 3.0;
            double trecina2 = 1 - 2 / 3.0;

            // :034 Ispisati vrijednosti varijabli trećina1 i trećina2 te njihove razlike (trećina1-trećina1), odn. (trećina1-tećina2).
            Console.WriteLine(trecina1);
            Console.WriteLine(trecina2);
            Console.WriteLine(trecina1-trecina1);
            Console.WriteLine(trecina1-trecina2);

            // Primjer utjecaja ograničenog raspona na rezultat množenja i dijeljenja:
            // :035 Definirati varijablu tipa double s vrijednošću double.MaxValue te ispisati rezultat njenog množenja s 2. Ponoviti to za double.MinValue.
            double a = double.MaxValue;
            Console.WriteLine(a*2);

            double b = double.MinValue;
            Console.WriteLine(b*2);

            // Primjeri neodređenih rezultata dijeljenja:
            // :036 Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double c = 23.4;
            double d = -23.4;

            Console.WriteLine(c / 0);
            Console.WriteLine(d / 0);

            // :037 Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            double e = 0;
            Console.WriteLine(e / 0);

            // :038 Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double f = 5;
            Console.WriteLine(f);

            // :039 Varijabli tipa int pridružiti vrijednost prethodno definirane varijable i ispisati njenu vrijednost.
            // int g = f;  
            // Console.WriteLine(g);
            //     Cannot implicitly convert type double to int.

            Console.ReadKey();
        }
    }
}
