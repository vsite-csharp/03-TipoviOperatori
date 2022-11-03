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
            // 120 Napisati naredbu kojom će se ispisati duljina podatka tipa decimal 
            Console.WriteLine(sizeof(decimal));
            // 121 Napisati naredbu kojom će se ispisati duljina podatka tipa double 
            Console.WriteLine(sizeof(double));

            // 122 Ispisati duljinu tipa MojaStruktura
            unsafe { // za korisnički definirane tipove treba uključiti unsafe i u properties eneble unsafe u build
            Console.WriteLine(sizeof(MojaStruktura));
                }
            // 123 Ispisati duljinu tipa MojaSloženaStruktura
            unsafe
            {
                Console.WriteLine(sizeof(MojaSloženaStruktura)); // funkcije se spremaju na drugo mjesto
                                                                 // u memoriji pa ne sudjeluju u sizeof
                                                                 // sve funkcije istog tipa objekta idu na
                                                                 //posebno mjesto u memoriji
            }
            // 124 Ispisati duljinu tipa MojaKlasa
            // za referentne tipove ne radi sizeof


            Console.ReadKey();
        }
    }
}
