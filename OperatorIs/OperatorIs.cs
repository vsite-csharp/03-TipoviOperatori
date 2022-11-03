using System;

namespace Vsite.CSharp.TipoviOperatori
{
	class Osoba { }

	class Student : Osoba { }

	class Program
	{
		static void Main()
		{
			// 100 Dodajte provjere za objekt osoba je li tipa Osoba i tipa Student te ispišite rezultate.
			Osoba osoba = new Osoba();
			Console.WriteLine(osoba is Osoba);
			Console.WriteLine(osoba is Student);

			// 101 Dodajte provjere za objekt janko je li tipa Osoba i tipa Student te ispišite rezultate.
			Osoba janko = new Student();
            Console.WriteLine(janko is Osoba);
            Console.WriteLine(janko is Student);

            Console.ReadKey();
		}
	}
}
