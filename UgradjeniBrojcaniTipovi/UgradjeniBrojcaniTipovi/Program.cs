﻿using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            int a = int.Parse("12");

            int veliki = int.MaxValue;
            Console.WriteLine(++veliki);

            int mali = int.MinValue;
            Console.WriteLine(--mali);
       
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            
            double b = 3.0;
            Console.WriteLine(b / 0); // infinity
           // Console.WriteLine(a / 0); //exception
            
            //double c = 0.0;
            //Console.WriteLine(c / 0);
            
            double d = 5.0;
            int e = (int)d;
           
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            double g = (double)decimal.MaxValue;

            double f1 = 1.23456789e23F;
            double f2 = 1.23456788e23F;

            Console.WriteLine(f1 - f2);
            Console.ReadKey();
        }
    }
}
