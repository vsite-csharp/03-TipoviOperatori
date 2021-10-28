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

            // Dodati pozive svih mogućih metoda za objekte osoba i nuklFizičar, pokrenuti program i provjeriti rezultat izvođenja.
            osoba.Hodaj();
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();

            // Dodati pozive svih mogućih metoda za objekt osobaNuklFiz, pokrenuti program i provjeriti rezultat.
            Osoba osobaNuklFiz = new NuklearniFizičar();
            osobaNuklFiz.Hodaj();
            //osobaNuklFiz.NapraviBombu();  //Tretira se kao Osoba te nema tu metodu na rapolaganju.
           

            // Provjeriti koja su od donjih pridruživanja dozvoljena. Modificirajte naredbe tako da prevoditelj ne prijavljuje pogreške.
            osobaNuklFiz = nuklFizičar;   //baznome Osoba pridruzujemo izvedeni NuklearniFizičar tip dozvoljeno
            nuklFizičar = (NuklearniFizičar)osobaNuklFiz;  //nemoze implicitno ako ocemo obrnut smjer
            nuklFizičar.NapraviBombu();

            // Dodati naredbu koja će omogućiti da se na objektu osobaNuklFiz pozove metoda NapraviBombu, pokrenuti program i provjeriti rezultat izvođenja.
            //if (osobaNuklFiz is NuklearniFizičar)
            //{
            //    osobaNuklFiz = osobaNuklFiz as NuklearniFizičar;
            //    NuklearniFizičar nuklearniFizičar = osobaNuklFiz as NuklearniFizičar;
            //    nuklearniFizičar.
            //}

            // Otkomentirati donje naredbe, provjeriti prijavljuje li program pogreške, pokrenuti program i provjeriti rezultat izvođenja.
            Osoba novaOsoba = osobaNuklFiz;
            nuklFizičar = (NuklearniFizičar)novaOsoba;
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();

            novaOsoba = osoba;
            // pec
            nuklFizičar = (NuklearniFizičar)novaOsoba;  //invalid cast exeption
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();


            Console.ReadKey();
        }
    }
}
