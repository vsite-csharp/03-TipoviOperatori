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
            Console.WriteLine(sizeof(decimal));

            Console.WriteLine(sizeof(double));

            //  Console.WriteLine(sizeof(MojaStruktura)); radi se o korisnički definiranom tipu

            unsafe
            {
                Console.WriteLine(sizeof(MojaStruktura));
            }

            unsafe
            {
                Console.WriteLine(sizeof(MojaSloženaStruktura));
            }


            //unsafe
            //{
            //    Console.WriteLine(sizeof(MojaKlasa));
            //}


            Console.ReadKey();
        }
    }
}
