using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int j = 2;
            int d = 1;
            Object k = j / d;
            if (k.GetType() == typeof(int))
            {
                Console.WriteLine("integer");
            }
            else if (k.GetType() == typeof(short))
            {
                Console.WriteLine("short");
            }
            else if (k.GetType() == typeof(double))
            {
                Console.WriteLine("double");
            }
            else if (k.GetType() == typeof(float))
            {
                Console.WriteLine("float");
            }
            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            int telj = 2;
            int nik = 5;
            Object k2 = telj / nik;
            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int max = int.MaxValue;
            long jedan = 1;
            Console.WriteLine("{} + {} = {}", max, jedan, max + jedan);
            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double pr = 2;
            int pr2 = 2;
            Object pr3 = pr + pr2;
            if (pr3.GetType() == typeof(int))
            {
                Console.WriteLine("integer");
            }
            else if (pr3.GetType() == typeof(short))
            {
                Console.WriteLine("short");
            }
            else if (pr3.GetType() == typeof(double))
            {
                Console.WriteLine("double");
            }
            else if (pr3.GetType() == typeof(float))
            {
                Console.WriteLine("float");
            }
            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal dec = 1;
            double dou = 2;
            //Object rez = dec + dou;
            
            //if (rez.GetType() == typeof(int))
            //{
            //    Console.WriteLine("integer");
            //}
            //else if (rez.GetType() == typeof(short))
            //{
            //    Console.WriteLine("short");
            //}
            //else if (rez.GetType() == typeof(double))
            //{
            //    Console.WriteLine("double");
            //}
            //else if (rez.GetType() == typeof(float))
            //{
            //    Console.WriteLine("float");
            //}
            Console.ReadKey();
        }
    }
}
