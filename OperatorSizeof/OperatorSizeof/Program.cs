﻿using System;

namespace Vsite.CSharp.TipoviOperatori
{
    struct MojaStruktura
    {
        decimal a;
        double b;
    }

    struct MojaSloženaStruktura
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class MojaKlasa
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sizeof(decimal);

            Console.WriteLine(sizeof(double);

            unsafe { Console.WriteLine(sizeof(MojaStruktura)); }

            unsafe {
                Console.WriteLine(sizeof(MojaSloženaStruktura));
            }
            // TODO:114  duljinu tipa MojaKlasa
            
              //  Console.WriteLine(sizeof(MojaKlasa));
            

            Console.ReadKey();
        }
    }
}
