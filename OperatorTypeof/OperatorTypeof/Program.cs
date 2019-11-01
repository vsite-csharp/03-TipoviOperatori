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
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }


            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.Write($"{mi.Name} {mi.ReturnType.ToString()}   ");
                if (mi.IsPublic)
                    Console.WriteLine("public");
                else if (mi.IsPrivate)
                    Console.WriteLine("private");
                else
                    Console.WriteLine("protected");
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType.ToString()} {parameter.Name}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
