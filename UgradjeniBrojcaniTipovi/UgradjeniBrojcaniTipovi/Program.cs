using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            int b = int.MaxValue;
            Console.WriteLine(b + 1);

            int c = int.MinValue;
            Console.WriteLine(c - 1);

            Console.WriteLine(double.MaxValue + " - " + double.MinValue);

            Console.WriteLine( 0.4 / 0); // inf
            Console.WriteLine( -1.2 / 0); // -inf

            Console.WriteLine(0.0 / 0); // NaN

            double d = 5;


            int x, y;
            double z = 5.7;                                                //ovo je samo proba , shift + alt
            //x = (int)z;                                                  //ovo je samo proba , shift + alt
            //y = (int)z;                                                  //ovo je samo proba , shift + alt
                                                                           //ovo je samo proba , shift + alt
            Console.WriteLine(decimal.MaxValue + " - " + decimal.MinValue);//ovo je samo proba , shift + alt

            double doub = (double)decimal.MaxValue;

            float f1, f2;
            f1 = 1.23456789e23F;
            f2 = 1.23456788e23F;

            Console.WriteLine(f1);
            Console.WriteLine(f2);



            Console.WriteLine(doub);

            Console.ReadKey();
        }
    }
}
