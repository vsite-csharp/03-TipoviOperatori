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
            foreach (MemberInfo mi in t.GetMembers())
                Console.WriteLine(mi.Name);

            // Dodati u petlji i ispis tipa svakog člana.
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType}");
            }

            // Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.
            foreach (MethodInfo mi in t.GetMethods())
                Console.WriteLine($"{mi.Name} {mi.MemberType}");

            // Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).
            foreach (MethodInfo mi in t.GetMethods())
                Console.WriteLine($"{mi.DeclaringType} {mi.DeclaringType.FullName}");

            // Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.
            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.ReturnType} {mi.Name}");
                if (mi.IsPublic)
                    Console.WriteLine("Public");
                else if (mi.IsPrivate)
                    Console.WriteLine("Private");
                else
                    Console.WriteLine("Protected");
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType} {parameter.Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
