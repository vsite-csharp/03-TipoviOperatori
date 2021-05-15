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
            MemberInfo[] polje = t.GetMembers();

            foreach (MemberInfo index in polje)
            {
                Console.WriteLine($"{index.Name}");
            }

            // Dodati u petlji i ispis tipa svakog člana.
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }
            // Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.
            foreach (MethodInfo iterator in t.GetMethods())
            {
                Console.WriteLine($"{iterator.Name}{iterator.ReturnType.ToString()}");
            }
            // Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).
            foreach (MethodInfo iterator in t.GetMethods())
            {
                Console.WriteLine($"{iterator.Name}{iterator.ReturnType.ToString()}");
                foreach (var parameter in iterator.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType.ToString()} {parameter.Name}");
                }
            }
            // Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.
            foreach (MethodInfo mi in t.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
            {
                if (mi.IsPrivate)
                {
                    Console.WriteLine($"private {mi.ReturnType.ToString()} {mi.Name}");
                }
                else if (mi.IsPublic)
                {
                    Console.WriteLine($"public {mi.ReturnType.ToString()} {mi.Name}");
                }
                else
                {
                    Console.WriteLine($"protected {mi.ReturnType.ToString()} {mi.Name}");
                }
                
                
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType.ToString()} {parameter.Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
