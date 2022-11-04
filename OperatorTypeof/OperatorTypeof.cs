using System;
using System.Reflection;

namespace Vsite.CSharp.TipoviOperatori
{
	class Program
	{
		static void Main()
		{
			Type t = typeof(System.DateTime);

			Console.WriteLine($"*** Svi članovi klase {t.Name} ***");

			// 130 Pokrenuti program i pogledati što će ispisati donja petlja.
			foreach (MemberInfo mi in t.GetMembers())
			{
				Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
			}

			Console.WriteLine($"*** Sve metode klase {t.Name} ***");

			// 131 Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.
			foreach (var mi in t.GetMethods()) {
				Console.WriteLine($"Ime: {mi.Name}, povratni tip: {mi.ReturnType}, pravo pristupa: {(mi.IsPublic ? "public" : mi.IsFamily ? "protected" : "private")}");
				foreach (var par in mi.GetParameters()) {
					Console.WriteLine($"Tip parametra {par.ParameterType}, Ime: {par.Name}");
				}
			}

            // 132 Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).

            // 133 Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.

            // 134 Napisati petlju koja će za donju instancu klase Object ispisati imena svih njenih članova.
            object o = new object();
			Console.WriteLine($"*** Svi članovi instance klase {o.GetType().Name} ***");

            foreach (MemberInfo mi in o.GetType().GetMembers()) {
                Console.WriteLine($"{mi.Name}");
            }
			//	ne mogu pushat
            Console.ReadKey();
		}
	}
}
