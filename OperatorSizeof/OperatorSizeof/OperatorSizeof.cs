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
        static void Main()
        {
            // :120 Napisati naredbu kojom će se ispisati duljina podatka tipa decimal 
            Console.WriteLine(sizeof(decimal));

            // :121 Napisati naredbu kojom će se ispisati duljina podatka tipa double 
            Console.WriteLine(sizeof(double));

            // :122 Ispisati duljinu tipa MojaStruktura
            unsafe
            {
                Console.WriteLine(sizeof(MojaStruktura));
                Console.WriteLine(sizeof(MojaSloženaStruktura));
            }
            // :123 Ispisati duljinu tipa MojaSloženaStruktura
            //Console.WriteLine(sizeof(MojaSloženaStruktura)); Line 47

            // :124 Ispisati duljinu tipa MojaKlasa
            //Console.WriteLine(sizeof(MojaKlasa));

            Console.ReadKey();
        }
    }
}
