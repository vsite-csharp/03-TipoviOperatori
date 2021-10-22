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
            Console.WriteLine($"\nnulabilniDuplić = {nulabilniDuplić}\n");
            // Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.
            //običniDuplić = nulabilniDuplić; // Cannot convert double to double?
            // Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.
            nulabilniDuplić = 23;
            Console.WriteLine($"nulabilniDuplić = {nulabilniDuplić}\n");
            // Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.
            //običniDuplić = nulabilniDuplić; // Cannot convert double to double?

            Console.ReadKey();
        }
    }
}
