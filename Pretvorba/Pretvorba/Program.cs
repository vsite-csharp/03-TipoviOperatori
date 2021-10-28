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
           

            // TODO:092 Provjeriti koja su od donjih pridruživanja dozvoljena. Modificirajte naredbe tako da prevoditelj ne prijavljuje pogreške.
            osobaNuklFiz = nuklFizičar;   //baznome Osoba pridruzujemo izvedeni NuklearniFizičar tip dozvoljeno
            //nuklFizičar = (NuklearniFizičar)osobaNuklFiz;  //nemoze implicitno ako ocemo obrnut smjer

            // TODO:093 Dodati naredbu koja će omogućiti da se na objektu osobaNuklFiz pozove metoda NapraviBombu, pokrenuti program i provjeriti rezultat izvođenja.
            if (osobaNuklFiz is NuklearniFizičar)
            {
                osobaNuklFiz = osobaNuklFiz as NuklearniFizičar;
                NuklearniFizičar nuklearniFizičar = osobaNuklFiz as NuklearniFizičar;
                nuklearniFizičar.
            }
       
            // TODO:094 Otkomentirati donje naredbe, provjeriti prijavljuje li program pogreške, pokrenuti program i provjeriti rezultat izvođenja.
            //Osoba novaOsoba = osobaNuklFiz;
            //nuklFizičar = (NuklearniFizičar)novaOsoba;
            //nuklFizičar.Hodaj();
            //nuklFizičar.NapraviBombu();

            //novaOsoba = osoba;
            //nuklFizičar = (NuklearniFizičar)novaOsoba;
            //nuklFizičar.Hodaj();
            //nuklFizičar.NapraviBombu();


            Console.ReadKey();
        }
    }
}
