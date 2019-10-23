using System;

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
            // TODO:110 Napisati naredbu kojom će se ispisati duljina podatka tipa decimal 

            // TODO:111 Napisati naredbu kojom će se ispisati duljina podatka tipa double 

            // TODO:112 Ispisati duljinu tipa MojaStruktura

            // TODO:113 Ispisati duljinu tipa MojaSloženaStruktura

            // TODO:114 Ispisati duljinu tipa MojaKlasa


            Console.ReadKey();
        }
    }
}
