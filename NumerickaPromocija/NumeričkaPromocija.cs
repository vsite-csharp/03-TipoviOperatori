namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            // TODO:040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int num1 = 10;
            int num2 = 3;
            var quotient = num1 / num2;
            Console.WriteLine(quotient.GetType());

            // TODO:041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            var remainder = num1 % num2;
            Console.WriteLine(remainder.GetType()); 

            // TODO:042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int intValue = int.MaxValue;
            long longValue = 1L;
            long sum = intValue + longValue;
            Console.WriteLine("intValue: " + intValue);
            Console.WriteLine("longValue: " + longValue); 
            Console.WriteLine("sum: " + sum);  

            // TODO:043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double doubleValue = 5.5;
            int intValue2 = 3;
            var sum2 = doubleValue + intValue2;
            Console.WriteLine(sum2.GetType()); 

            // TODO:044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom
            decimal decimalValue = 10.5m;
            double doubleValue2 = 5.5;
            var sum3 = decimalValue + (decimal)doubleValue2;
            Console.WriteLine(sum3.GetType()); 

            Console.ReadKey();
        }
    }
}
