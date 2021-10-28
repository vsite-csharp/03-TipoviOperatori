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
        static void Main()
        {
            // TODO:120 Napisati naredbu kojom će se ispisati duljina podatka tipa decimal 

            // TODO:121 Napisati naredbu kojom će se ispisati duljina podatka tipa double 

            // Ispisati duljinu tipa MojaStruktura
            unsafe
            {
                Console.WriteLine(sizeof(MojaStruktura));
            }

            // Ispisati duljinu tipa MojaSloženaStruktura
            unsafe
            {
                Console.WriteLine(sizeof(MojaSloženaStruktura));
            }

            // Ispisati duljinu tipa MojaKlasa
            //unsafe
            //{
            //    Console.WriteLine(sizeof(MojaKlasa));
            //}

            Console.ReadKey();
        }
    }
}
