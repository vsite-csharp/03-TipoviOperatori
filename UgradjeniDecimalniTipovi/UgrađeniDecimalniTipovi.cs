using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine(double.Parse("2"));

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);


            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;
            Console.WriteLine("{0:F2}",f1-f2);
            Console.WriteLine("{0:F2}",f1 -f3);

            double trecina = 1.0 / 3;
            double trecina2 = 1 - 2.0 / 3;
            Console.WriteLine("{0:F10}", trecina);
            Console.WriteLine("{0:F10}", trecina2);
            Console.WriteLine("{0:F10}", trecina - trecina2);

            double najveci = double.MaxValue;

            Console.WriteLine(najveci * 2);

            double a = 10;

            Console.WriteLine(a / 0.0);
            Console.WriteLine(0.0/ 0.0);

            double pet = 5;
            int c = (int)pet;

            Console.WriteLine(pet / c);

            Console.WriteLine("Enter key.");
            Console.ReadKey();
        }
    }
}
