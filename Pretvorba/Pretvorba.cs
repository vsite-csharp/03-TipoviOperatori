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

        public void NapraviDinamit()
        {
            Console.WriteLine("Bum goes the dynamite.");
        }
    }

    class Bandit : Osoba
    {
        public void Bjezi()
        {
            Console.WriteLine("I shoot the sheriff!!");
        }

        public void NastaviBjezati()
        {
            Console.WriteLine("But i didn't shoot no deputy!");
        }
    }


    static class Program
    {
        static void Main()
        {
            Osoba osoba = new Osoba();
            NuklearniFizičar nuklFizičar = new NuklearniFizičar();

            // ODO:090 Dodati pozive svih mogućih metoda za objekte osoba i nuklFizičar, pokrenuti program i provjeriti rezultat izvođenja.
            osoba.Hodaj();

            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();

            Osoba osobaNuklFiz = new NuklearniFizičar();

            // ODO:091 Dodati pozive svih mogućih metoda za objekt osobaNuklFiz, pokrenuti program i provjeriti rezultat.
            osobaNuklFiz.Hodaj();
            // ODO:092 Provjeriti koja su od donjih pridruživanja dozvoljena. Modificirajte naredbe tako da prevoditelj ne prijavljuje pogreške.
            osobaNuklFiz = nuklFizičar;
            nuklFizičar = (NuklearniFizičar)osobaNuklFiz;

            // ODO:093 Dodati naredbu koja će omogućiti da se na objektu osobaNuklFiz pozove metoda NapraviBombu, pokrenuti program i provjeriti rezultat izvođenja.
            ((NuklearniFizičar)osobaNuklFiz).NapraviBombu();

            // ODO:094 Otkomentirati donje naredbe, provjeriti prijavljuje li program pogreške, pokrenuti program i provjeriti rezultat izvođenja.
            Osoba novaOsoba = osobaNuklFiz;
            nuklFizičar = (NuklearniFizičar)novaOsoba;
            nuklFizičar.Hodaj();
            nuklFizičar.NapraviBombu();
            nuklFizičar.NapraviDinamit();

            //novaOsoba = osoba;
            //nuklFizičar = (NuklearniFizičar)novaOsoba;
            //nuklFizičar.Hodaj();
            //nuklFizičar.NapraviBombu();

            Bandit bandit = new Bandit();
            bandit.Hodaj();
            bandit.Bjezi();
            bandit.NastaviBjezati();


            Console.ReadKey();
        }
    }
}
