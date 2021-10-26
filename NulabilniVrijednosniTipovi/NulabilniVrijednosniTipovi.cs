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

            //   Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.
            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);
            //  Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.
            Console.WriteLine(običniDuplić + nulabilniDuplić);
            //  Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.
            nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);
            //  Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.
            Console.WriteLine(običniDuplić + nulabilniDuplić);
            Console.ReadKey();
        }
    }
}
