using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            // Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.
            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić); //ništa

            // Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.
            //običniDuplić = nulabilniDuplić; //implicitna pretvorba ne postoji; eksplicitna postoji, ali nulabilniDuplić mora imati vrijednost

            // Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.
            nulabilniDuplić = 12.3;
            Console.WriteLine(nulabilniDuplić);
            // Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.
            običniDuplić = (double)nulabilniDuplić;

            Console.ReadKey();
        }
    }
}
