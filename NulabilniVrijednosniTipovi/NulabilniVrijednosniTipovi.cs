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

            // :050  Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.
            nulabilniDuplić = null;
            Console.WriteLine($"nulabilniDuplić = {nulabilniDuplić}");

            // :051 Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.
            // običniDuplić = nulabilniDuplić;
            // Javlja gresku da ne moze konvertirati System.Nullable<double> u double

            // :052 Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.
            nulabilniDuplić = 4.5;
            Console.WriteLine($"nulabilniDuplić = {nulabilniDuplić}");

            // :053 Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.
            //običniDuplić = nulabilniDuplić;
            // i dalje javlja istu gresku. Vjerojatno zato sto ne postoji implicitna konverzija izmedu double? i double
            // ovako bi radilo: običniDuplić = (double)nulabilniDuplić;

            Console.ReadKey();
        }
    }
}
