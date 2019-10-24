using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ispisati najveći i najmanji broj koji se može pohraniti u tip int.
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            // Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            int veliki = int.MaxValue;
            Console.WriteLine(++veliki);
            // Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            int mali = int.MinValue;
            Console.WriteLine(--mali);
            // Ispisati granične vrijednosti za tip double.
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            // Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog broja tipa double s 0 te dijeljenja negativnog broja tipa double s 0.
            double a = 3.0;
            Console.WriteLine(a / 0);
            // Provjeriti što će se ispisati kao rezultat kada se varijabla tipa double s vrijednošću 0 podijeli s 0.
            a = 0.0;
            Console.WriteLine(a / 0);
            // Definirati varijablu tipa double i pridružiti joj vrijednost 5.
            double b = 5.0;
            // Dvjema varijablama tipa int pridružiti vrijednost prethodno definirane varijable, odnosno najvećeg broja tipa double i ispisati njihove vrijednosti.
            int c = (int)b;
            // Ispisati najveće i najmanje vrijednosti tipa decimal.
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            // Varijabli tipa double pridružiti najveću vrijednost tipa double i ispisati rezultat.
            double d = (double)decimal.MaxValue;

            double f1 = 1.23456789e23;
            double f2 = 1.23456788e23;
            Console.WriteLine(f1 - f2);

            Console.ReadKey();
        }
    }
}
