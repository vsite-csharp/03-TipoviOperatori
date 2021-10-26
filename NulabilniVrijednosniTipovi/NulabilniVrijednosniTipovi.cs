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

            // 050  Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.
            nulabilniDuplić = null;
            Console.WriteLine("Sadrzaj nulabilniDuplic = {0}", nulabilniDuplić); // ne pokazaje ni na sta

            // 051 Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.
            // običniDuplić = nulabilniDuplić; // ne moze se konvertirati

            // 052 Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.
            nulabilniDuplić = 56;
            Console.WriteLine("Sadrzaj nulabilniDuplic = {0}, tip: {1}", nulabilniDuplić, nulabilniDuplić.GetType()); // 56

            // 053 Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.
            //običniDuplić = nulabilniDuplić; // ne moze se konvertati

            Console.ReadKey();
        }
    }
}
