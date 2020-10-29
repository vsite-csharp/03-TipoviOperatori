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
            Console.WriteLine("double.MinValue : {0}", double.MinValue);
            Console.WriteLine("double.MaxValue : {0}", double.MaxValue);
            Console.WriteLine("float.MinValue : {0}", float.MinValue);
            Console.WriteLine("float.MaxValue : {0}", float.MaxValue);
            Console.WriteLine("decimal.MinValue : {0}", decimal.MinValue);
            Console.WriteLine("decimal.MaxValue : {0}", decimal.MaxValue);

            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;

            Console.WriteLine("{0:F2} - {1:F2} = {2:F2}", f1, f2, f1 - f2);
            Console.WriteLine("{0:F2} - {1:F2} = {2:F2}", f1, f3, f1 - f3);
            
            double trecina1 = 1.0 / 3;
            double trecina2 = 1 - 2.0 / 3;

            Console.WriteLine("{0:F20} - {1:F20} = {2:F20}", trecina1, trecina1, trecina1- trecina1);
            Console.WriteLine("{0:F20} - {1:F20} = {2:F20}", trecina1, trecina2, trecina1 - trecina2);

            double max = double.MaxValue;
            Console.WriteLine(max * 2);
            double a = 10;
            a /= 0.0;
            Console.WriteLine(a);
            double nula = 0.0;
            nula /= 0.0;
            Console.WriteLine(nula);
            double pet = 5;
            int c = (int)pet;
            Console.WriteLine(pet);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
