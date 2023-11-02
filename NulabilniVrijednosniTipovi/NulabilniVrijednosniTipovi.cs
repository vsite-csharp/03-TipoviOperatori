using System;
using System.Reflection;

namespace Vsite.CSharp.TipoviOperatori
{
    class MojaKlasa
    {
        public int a = 10;
    }

    static class Program
    {
        static void Main()
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);
            // 050 Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.
            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);
            // 051 Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.
            if (nulabilniDuplić.HasValue)
            {
                običniDuplić = nulabilniDuplić.Value;
                Console.WriteLine(običniDuplić);
            }
            // TODO:052 Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.
            nulabilniDuplić = 1;
            Console.WriteLine(nulabilniDuplić);

            // TODO:053 Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.


            // TODO:054 Otkomentirati donje naredbe, provjeriti prevodi li se kod, pogledati upozorenja te pokrenuti program i provjeriti ispis.
            // TODO:055 Deklarirati mk da je nulabilni tip te ponoviti gornje korake.
            // TODO:056 Ispred drugog poziva za ispis dodati provjeru je li mk inicijaliziran te ispis napraviti samo u tom slučaju.
            MojaKlasa? mk = new MojaKlasa();

            Console.WriteLine(mk.a);

            mk = null;

            if(nk != null)
            {
                Console.WriteLine(mk.a);
            }


            Console.ReadKey();
        }
    }
}
