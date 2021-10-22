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

            //Dodati pozive svih mogućih metoda za objekte osoba i nuklFizičar, pokrenuti program i provjeriti rezultat izvođenja.
            osoba.Hodaj();
            osoba.Equals(osoba);
            osoba.GetHashCode();
            osoba.GetType();
            osoba.ToString();

            nuklFizičar.NapraviBombu();
            nuklFizičar.Hodaj();
            nuklFizičar.Equals(nuklFizičar);
            nuklFizičar.GetHashCode();
            nuklFizičar.GetType();
            nuklFizičar.ToString();


            Osoba osobaNuklFiz = new NuklearniFizičar();

            //Dodati pozive svih mogućih metoda za objekt osobaNuklFiz, pokrenuti program i provjeriti rezultat.

            osobaNuklFiz.Hodaj();
            osobaNuklFiz.Equals(osoba);
            osobaNuklFiz.GetHashCode();
            osobaNuklFiz.GetType();
            osobaNuklFiz.ToString();


            // Provjeriti koja su od donjih pridruživanja dozvoljena. Modificirajte naredbe tako da prevoditelj ne prijavljuje pogreške.
            osobaNuklFiz = nuklFizičar;
            nuklFizičar = osobaNuklFiz as NuklearniFizičar;

            //Dodati naredbu koja će omogućiti da se na objektu osobaNuklFiz pozove metoda NapraviBombu, pokrenuti program i provjeriti rezultat izvođenja.
            (osobaNuklFiz as NuklearniFizičar)?.NapraviBombu();

            // Otkomentirati donje naredbe, provjeriti prijavljuje li program pogreške, pokrenuti program i provjeriti rezultat izvođenja.
            Osoba novaOsoba = osobaNuklFiz;
            nuklFizičar = (NuklearniFizičar)novaOsoba;
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();

            novaOsoba = osoba;
            nuklFizičar = (NuklearniFizičar)novaOsoba;
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();


            Console.ReadKey();
        }
    }
}
