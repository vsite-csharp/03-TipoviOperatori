using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            int a = 10, b = 3;
            Console.WriteLine(a / b);

            Console.WriteLine((double)a / b);
            int najveci = int.MaxValue;
            long dugi = 1;
            Console.WriteLine("{0}, {1}, {2}", najveci, dugi, najveci + dugi);
            double dupli = 3.14;
            int c = 4;
            Console.WriteLine(dupli + c);
            Console.WriteLine(c / dupli);
            decimal dec = 3.14M;
            Console.WriteLine(dec + (decimal)dupli);
            Console.ReadKey();
        }
    }
}
