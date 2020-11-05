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
            // Napisati naredbu kojom će se ispisati duljina podatka tipa decimal 
            Console.WriteLine(sizeof(decimal)); //16

            // Napisati naredbu kojom će se ispisati duljina podatka tipa double 
            Console.WriteLine(sizeof(double)); //8


            unsafe
            {
                // Ispisati duljinu tipa MojaStruktura
                Console.WriteLine(sizeof(MojaStruktura)); //24

                // Ispisati duljinu tipa MojaSloženaStruktura
                Console.WriteLine(sizeof(MojaSloženaStruktura)); //24

                // Ispisati duljinu tipa MojaKlasa
                //Console.WriteLine(sizeof(MojaKlasa)); //referentni tip
            }

            Console.ReadKey();
        }
    }
}
