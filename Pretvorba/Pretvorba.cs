﻿namespace Vsite.CSharp.TipoviOperatori
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


    static class Program
    {
        static void Main()
        {
            var osoba = new Osoba();
            var nuklFizičar = new NuklearniFizičar();

            // TODO:090 Dodati pozive svih mogućih metoda za objekte osoba i nuklFizičar, pokrenuti program i provjeriti rezultat izvođenja.

            Osoba osobaNuklFiz = new NuklearniFizičar();

            // TODO:091 Dodati pozive svih mogućih metoda za objekt osobaNuklFiz, pokrenuti program i provjeriti rezultat.

            // TODO:092 Provjeriti koja su od donjih pridruživanja dozvoljena. Modificirajte naredbe tako da prevoditelj ne prijavljuje pogreške.
            //osobaNuklFiz = nuklFizičar;
            //nuklFizičar = osobaNuklFiz;

            // TODO:093 Dodati naredbu koja će omogućiti da se na objektu osobaNuklFiz pozove metoda NapraviBombu, pokrenuti program i provjeriti rezultat izvođenja.


            // TODO:094 Otkomentirati donje naredbe, provjeriti prijavljuje li program pogreške, pokrenuti program i provjeriti rezultat izvođenja.
            //Osoba novaOsoba = osobaNuklFiz;
            //nuklFizičar = (NuklearniFizičar)novaOsoba;
            //nuklFizičar.Hodaj();
            //nuklFizičar.NapraviBombu();

            //novaOsoba = osoba;
            //nuklFizičar = (NuklearniFizičar)novaOsoba;
            //nuklFizičar.Hodaj();
            //nuklFizičar.NapraviBombu();


            Console.WriteLine("GOTOVO!!!");
        }
    }
}
