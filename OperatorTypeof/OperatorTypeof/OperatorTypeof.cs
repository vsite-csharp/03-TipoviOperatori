using System;
using System.Reflection;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            Type t = typeof(System.DateTime);

            // Napisati petlju koja će za svaki član kojeg vrati metoda t.GetMembers ispisati ime tog člana.

            // Dodati u petlji i ispis tipa svakog člana.
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }


            // Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.

            // Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).

            // Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.
            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.ReturnType.ToString()} {mi.Name}");
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType.ToString()} {parameter.Name}");
                }
            }
            object o = new Object();
            var type = o.GetType();
            foreach (var mi in type.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }

            Console.ReadKey();
        }
    }
}
