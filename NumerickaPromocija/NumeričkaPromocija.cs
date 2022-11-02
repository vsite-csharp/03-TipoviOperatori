using System;

namespace Vsite.CSharp.TipoviOperatori
{
	class Program
	{
		static void Main()
		{
			// 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
			int intBroj1 = 3, intBroj2 = 2;
			Console.WriteLine("{0} / {1} = {2}\t- {3}", intBroj1, intBroj2, (intBroj1 / intBroj2), (intBroj1 / intBroj2).GetType());
			
			// 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
			Console.WriteLine("{0} / {1} = {2}\t- {3}", intBroj1, intBroj2, ((double)intBroj1 / intBroj2), ((double)intBroj1 / intBroj2).GetType());
			
			// 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
			int maxI = int.MaxValue;
			long longOne = 1;
			Console.WriteLine("maxI\t= {0}\nlongOne\t= {1}", maxI, longOne);
			Console.WriteLine((maxI + longOne) + "\t- " + (maxI + longOne).GetType());
            
			// 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
			double dvanaest = 12.0;
			Console.WriteLine((dvanaest + maxI) + "\t- " + (dvanaest + maxI).GetType());
            
			// 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
			decimal dec = 10.1M;
            //Console.WriteLine((dvanaest + dec) + "\t- " + (dvanaest + dec).GetType());    //operator error

            Console.ReadKey();
			
        }
    }
}
