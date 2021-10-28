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

            // 090 Dodati pozive svih mogućih metoda za objekte osoba i nuklFizičar, pokrenuti program i provjeriti rezultat izvođenja.

            osoba.Hodaj();
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();

            Osoba osobaNuklFiz = new NuklearniFizičar(); 

            // 091 Dodati pozive svih mogućih metoda za objekt osobaNuklFiz, pokrenuti program i provjeriti rezultat.

            osobaNuklFiz.Hodaj();

            // 092 Provjeriti koja su od donjih pridruživanja dozvoljena. Modificirajte naredbe tako da prevoditelj ne prijavljuje pogreške.
            osobaNuklFiz = nuklFizičar; // This is ok 
            //nuklFizičar = osobaNuklFiz; // Initial it is NukleraniFizičar, but declaration is Osoba
            // If you are sure, you can make cast 


            // 093 Dodati naredbu koja će omogućiti da se na objektu osobaNuklFiz pozove metoda NapraviBombu, pokrenuti program i provjeriti rezultat izvođenja.
            nuklFizičar = (NuklearniFizičar)osobaNuklFiz;
            nuklFizičar.NapraviBombu();

            // TODO:094 Otkomentirati donje naredbe, provjeriti prijavljuje li program pogreške, pokrenuti program i provjeriti rezultat izvođenja.
            Osoba novaOsoba = osobaNuklFiz;
            nuklFizičar = (NuklearniFizičar)novaOsoba;
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();

            novaOsoba = osoba;
            nuklFizičar = (NuklearniFizičar)novaOsoba; // bazni u izvedeni nije moguće 
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();


            Console.ReadKey();
        }
    }
}
