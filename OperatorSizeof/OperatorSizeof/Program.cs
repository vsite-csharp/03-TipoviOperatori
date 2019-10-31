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
         

            Console.WriteLine(sizeof(decimal)); //16
            
            Console.WriteLine(sizeof(double));
            
            unsafe
            {
                Console.WriteLine(sizeof(MojaStruktura));//allow unsafe
                Console.WriteLine(sizeof(MojaSloženaStruktura));
            }

            
            //ctr+shift+v
            //Console.WriteLine(sizeof(MojaKlasa));...neće jer je referentni tip i neće moći izračunati; ne zna pravu veličinu klase; nema smisla
           
            Console.ReadKey();
        }
    }
}
