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

            // 122 Ispisati duljinu tipa MojaStruktura
            unsafe // Properties, Build, check Allow unsafe code 
            {
                Console.WriteLine(sizeof(MojaStruktura));  // ispisuje veličinu strukture ovisno o double, integer 128 bit = 16 byte
                Console.WriteLine(sizeof(MojaSloženaStruktura));
            }

            // 123 Ispisati duljinu tipa MojaSloženaStruktura

            // TODO:124 Ispisati duljinu tipa MojaKlasa
            unsafe // Properties, Build, check Allow unsafe code 
            {
               //Console.WriteLine(sizeof(MojaKlasa)); //Za referetne tipove ne može odrediti 
            }

            Console.ReadKey();
        }
    }
}
