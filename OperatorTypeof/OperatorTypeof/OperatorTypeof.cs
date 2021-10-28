using System;
using System.Reflection;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            Type t = typeof(System.DateTime);

            // :130 Napisati petlju koja će za svaki član kojeg vrati metoda t.GetMembers ispisati ime tog člana.
            foreach(MemberInfo mi in t.GetMembers())
                Console.WriteLine(mi.Name);

            Console.WriteLine("____________________________________________________________________________");
            // :131 Dodati u petlji i ispis tipa svakog člana.
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }

            Console.WriteLine("____________________________________________________________________________");
            // :132 Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.
            foreach (MemberInfo mi in t.GetMethods())
                Console.WriteLine($"{mi.Name} {mi.DeclaringType}");


            Console.WriteLine("____________________________________________________________________________");
            // :133 Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).
            // TODO:134 Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.
            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.ReturnType.ToString()} {mi.Name}");
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"   {parameter.ParameterType.ToString()} {parameter.Name}");
                }
            }

            Console.WriteLine("____________________________________________________________________________");

            object o = new object();
            var type = o.GetType();
            foreach (MemberInfo mi in type.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }

            Console.ReadKey();
        }
    }
}
