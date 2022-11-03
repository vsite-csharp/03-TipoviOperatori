using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba
    {
        public void Hodaj()
        {
            Console.WriteLine("Hodam");
        }
    }

    class NuklearniFizičar : Osoba
    {
        public void NapraviBombu()
        {
            Console.WriteLine("Bum");
        }
    }


    class Program
    {
        static void Main()
        {
            Osoba osoba = new Osoba();
            NuklearniFizičar nuklFizičar = new NuklearniFizičar();
            osoba.Hodaj();
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();


            Osoba osobaNuklFiz = new NuklearniFizičar();
            osobaNuklFiz.Hodaj();
            ((NuklearniFizičar)osobaNuklFiz).NapraviBombu();

            osobaNuklFiz = nuklFizičar;
            //nuklFizičar = osobaNuklFiz;




            Osoba novaOsoba = osobaNuklFiz;
            nuklFizičar = (NuklearniFizičar)novaOsoba;
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();

            novaOsoba = osoba;
            //nuklFizičar = (NuklearniFizičar)novaOsoba;
            //nuklFizičar.Hodaj();
            //nuklFizičar.NapraviBombu();


            Console.ReadKey();
        }
    }
}
