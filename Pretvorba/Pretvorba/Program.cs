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

            //  Dodati pozive svih mogućih metoda za objekte osoba i nuklFizičar, pokrenuti program i provjeriti rezultat izvođenja.
            osoba.Hodaj();
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();

            Osoba osobaNuklFiz = new NuklearniFizičar();
            //  Dodati pozive svih mogućih metoda za objekt osobaNuklFiz, pokrenuti program i provjeriti rezultat.
            //za pomicanje redova alt+strelice
            osobaNuklFiz.Hodaj();

            //  Provjeriti koja su od donjih pridruživanja dozvoljena. Modificirajte naredbe tako da prevoditelj ne prijavljuje pogreške.
            osobaNuklFiz = nuklFizičar;//izvedeni tip se moze pridruziti baznom,obrnuto ne
            //nuklFizičar = osobaNuklFiz;

            //  Dodati naredbu koja će omogućiti da se na objektu osobaNuklFiz pozove metoda NapraviBombu, pokrenuti program i provjeriti rezultat izvođenja.
            ((NuklearniFizičar)osobaNuklFiz).NapraviBombu();

            //  Otkomentirati donje naredbe(ctrl+k,u), provjeriti prijavljuje li program pogreške, pokrenuti program i provjeriti rezultat izvođenja.
            Osoba novaOsoba = osobaNuklFiz;
            nuklFizičar = (NuklearniFizičar)novaOsoba;
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();//sve ce proci

            //pao je jer pokusavam objektu novaosoba kaskati u nuk.fiz 
            ////program nez kako bi osobu pretvorio u tip fiz koji ima vise tipova od orginala
            //nuklFizičar = (NuklearniFizičar)novaOsoba;
            //novaOsoba = osoba;
            //nuklFizičar.Hodaj();
            //nuklFizičar.NapraviBombu();

            Console.ReadKey();
        }
    }
}
