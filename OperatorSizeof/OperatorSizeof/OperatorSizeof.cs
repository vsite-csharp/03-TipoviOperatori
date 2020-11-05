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
            //  Napisati naredbu kojom će se ispisati duljina podatka tipa decimal 
            Console.WriteLine(sizeof(decimal));
            //decimal zauzima 16 bajtova u memoriji


            //  Napisati naredbu kojom će se ispisati duljina podatka tipa double 
            Console.WriteLine(sizeof(double));
            //double zauzima 8 bajtova u memoriji 
            unsafe//jer ove dole naredbe ne bi mogli koristiti + u properties moramo oznaciti unsafe code
                //vrijedi za strukture
                //a za klasu :
                //ne mozemo dobiti informaciju o velicini tj duljinu jer se sprema u posebni dio memorije
            {
                //  Ispisati duljinu tipa MojaStruktura
                Console.WriteLine(sizeof(MojaStruktura));

                MojaStruktura ms = new MojaStruktura();
                //Console.WriteLine(sizeof(ms.GetType));
                // zauzima 24 bajtova u memoriji jer se a i b zbrajaju 16+8

                //  Ispisati duljinu tipa MojaSloženaStruktura
                Console.WriteLine(sizeof(MojaSloženaStruktura));

                //  Ispisati duljinu tipa MojaKlasa
               // Console.WriteLine(sizeof(MojaKlasa)); //error -objasnjenje gore
            }

            Console.ReadKey();
        }
    }
}
