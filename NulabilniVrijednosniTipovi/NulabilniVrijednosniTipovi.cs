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
            Console.WriteLine(nulabilniDuplić);
            
            // Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.
            //običniDuplić = nulabilniDuplić;  //cannot inplicity convert double? to double
            
            // Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.
            nulabilniDuplić = 77;
            Console.WriteLine(nulabilniDuplić);
            
            // Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.
            običniDuplić = (double)nulabilniDuplić;  //cannot inplicity convert double? to double

            Console.ReadKey();
        }
    }
}
