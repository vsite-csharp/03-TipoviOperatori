using System;

namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            // TODO:050  Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.

            // TODO:051 Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.

            // TODO:052 Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.

            // TODO:053 Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.

            Console.ReadKey();
        }
    }
}
