using System;
using System.Linq.Expressions;

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
            // 120 Napisati naredbu kojom će se ispisati duljina podatka tipa decimal 
            Console.WriteLine(sizeof(decimal));

            // 121 Napisati naredbu kojom će se ispisati duljina podatka tipa double 
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(int));

            // 122 Ispisati duljinu tipa MojaStruktura
            unsafe
            {
                Console.WriteLine(sizeof(MojaStruktura));
            }

            // 123 Ispisati duljinu tipa MojaSloženaStruktura
            unsafe
            {
                Console.WriteLine(sizeof(MojaSloženaStruktura));

            // 124 Ispisati duljinu tipa MojaKlasa
            //} unsafe
            //{
            //    Console.WriteLine(sizeof(MojaKlasa));
            //}


            Console.ReadKey();
        }
    }
}
