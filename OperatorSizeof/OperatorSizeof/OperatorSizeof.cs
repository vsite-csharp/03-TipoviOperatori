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
            // TODO:120 Napisati naredbu kojom će se ispisati duljina podatka tipa decimal 
            Console.WriteLine(sizeof(decimal));
            // TODO:121 Napisati naredbu kojom će se ispisati duljina podatka tipa double 
            Console.WriteLine(sizeof(double));
            // TODO:122 Ispisati duljinu tipa MojaStruktura
            //Console.WriteLine(sizeof(MojaStruktura));
            // TODO:123 Ispisati duljinu tipa MojaSloženaStruktura

            // TODO:124 Ispisati duljinu tipa MojaKlasa


            Console.ReadKey();
        }
    }
}
