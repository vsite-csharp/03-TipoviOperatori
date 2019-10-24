using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:030 Ispisati najveći i najmanji broj koji se može pohraniti u tip int.
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            int a = int.MaxValue;
            a++;
            Console.WriteLine(a);
           int b = int.MinValue;
            b--;


            double c = 2.3;
            Console.WriteLine(c / 0);
            c = - 2.3;
            Console.WriteLine(c / 0);

            c = 0;
            Console.WriteLine(c / 0);
            // TODO:036 Definirati varijablu tipa double i pridružiti joj vrijednost 5.

            //double d = 5;
            //d = double.MaxValue;
            //int e = d;
            //Console.WriteLine(e);
            //d = double.MinValue;
            //e = d;
            //Console.WriteLine(e);


            // TODO:038 Ispisati najveće i najmanje vrijednosti tipa decimal.
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            // TODO:039 Varijabli tipa double pridružiti najveću vrijednost tipa double i ispisati rezultat.
            double z = double.MaxValue;
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
