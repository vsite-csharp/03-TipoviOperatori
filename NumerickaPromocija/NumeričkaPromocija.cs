namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 45; int b = 22;
            Console.WriteLine(a / b);

            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            double a2 = (double)a;
            Console.WriteLine(a2 / b);
            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int num = int.MaxValue;
            long num2 = 1;
            Console.WriteLine("Int: " + num + "\nLong: "+ num2 +"\nZbroj: "+ (num + num2));
            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double num3 = 4;
            int num4 = 6;
            Console.WriteLine("Tip podatka: " + (num3 + num4).GetType());
            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal num5 = 13.4m;
            double num6 = 3.14;
            //Console.WriteLine("Tip podatka: " + (num5 + num6).GetType()); ne mogu se zbrojiti ta dva tipa
            Console.ReadKey();
        }
    }
}
