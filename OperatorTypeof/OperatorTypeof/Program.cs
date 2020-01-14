using System;
using System.Reflection;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(System.DateTime);

            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name}");
            }

            //foreach (MemberInfo mi in t.GetMembers())
            //{
            //    Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            //}
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }

             foreach (MemberInfo mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }
            // TODO:123 Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).

            // TODO:124 Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.
            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.ReturnType.ToString()} {mi.Name}");
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType.ToString()} {parameter.Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
