using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int numerator = 1;
            int denumerator = 2;
            Console.WriteLine("Quotient: " + (numerator / denumerator) + "\nQuotient type: " + (numerator / denumerator).GetTypeCode());
            // Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            double numerator1 = 1;
            int denumerator1 = 2;
            Console.WriteLine("\nQuotient: " + (numerator1 / denumerator1) + "\nQuotient type: " + (numerator1 / denumerator1).GetTypeCode());
            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int max = int.MaxValue;
            long one = 1;
            Console.WriteLine($"\nmax = {max}, one = {one}, max + one = {max + one}");
            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double doubleNumber = 1;
            int intNumber = 1;
            Console.WriteLine("\nSum type: " + (doubleNumber + intNumber).GetTypeCode());
            // Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal number = 5;
            //Console.WriteLine($"\nSum: " + (number + doubleNumber) +"\nSum type: " + (number + doubleNumber).GetTypeCode()); // Cannot add decimal and double type.
            Console.WriteLine($"\nSum: " + (number + (decimal)doubleNumber) +"\nSum type: " + (number + (decimal)doubleNumber).GetTypeCode());
            Console.ReadKey();
        }
    }
}
