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
            foreach (var memberInfo in t.GetMembers())
            {
                Console.WriteLine(memberInfo.Name);
            }

            Console.WriteLine("==============================");
            Console.WriteLine();
            // Dodati u petlji i ispis tipa svakog člana.
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }

            Console.WriteLine("==============================");
            Console.WriteLine();
            // Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.
            foreach (var mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.Name} {mi.ReturnType}");
            }
            // Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).
            foreach (var mi in t.GetMethods())
            {
                foreach (var parameterInfo in mi.GetParameters())
                {
                    Console.WriteLine($"{parameterInfo.Name} {parameterInfo.ParameterType}");
                }
               
            }
            // Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.
            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.ReturnType.ToString()} {mi.Name}");
                Console.WriteLine($">>>>>>>>>>>>>Is Pivate {mi.IsPrivate}");
                Console.WriteLine($">>>>>>>>>>>>>Is Public {mi.IsPublic}");
                Console.WriteLine($">>>>>>>>>>>>>Is Protected {mi.IsFamily}");
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType.ToString()} {parameter.Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
