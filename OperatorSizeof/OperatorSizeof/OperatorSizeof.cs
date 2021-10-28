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
            Console.WriteLine("Decimal duljina " + sizeof(decimal));

            // Napisati naredbu kojom će se ispisati duljina podatka tipa double 
            Console.WriteLine("Double duljina " + sizeof(double));

            // Ispisati duljinu tipa MojaStruktura
            Console.WriteLine("MojaStruktura duljina " + System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaStruktura)));

            // Ispisati duljinu tipa MojaSloženaStruktura
            Console.WriteLine("MojaSloženaStruktura duljina " + System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaSloženaStruktura)));

            unsafe
            {
                Console.WriteLine(sizeof(MojaStruktura));
                Console.WriteLine(sizeof(MojaSloženaStruktura));
            }

            // Ispisati duljinu tipa MojaKlasa
            Console.WriteLine("MojaKlasa duljina " + System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaKlasa)));


            Console.ReadKey();
        }
    }
}
