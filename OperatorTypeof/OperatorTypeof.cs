using System;
using System.Reflection;

namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            Type t = typeof(System.DateTime);

            Console.WriteLine($"*** Svi članovi klase {t.Name} ***");

            // :130 Pokrenuti program i pogledati što će ispisati donja petlja.
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }

            Console.WriteLine($"*** Sve metode klase {t.Name} ***");

            // :131 Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.
            foreach(var method in t.GetMethods())
            {
                Console.WriteLine($"{method.Name} {method.ReturnType}");
            }
            // :132 Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).
            foreach (var method in t.GetMethods())
            {
                Console.WriteLine($"{method.Name} {method.ReturnType}");
                foreach (var parameters in method.GetParameters())
                {
                    Console.WriteLine($"{parameters.Name} {parameters.ParameterType}");
                }
            }
            // :133 Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.
            foreach (var method in t.GetMethods())
            {
                Console.WriteLine($"{method.Name} {method.ReturnType}");

                string pravo = "";
                if (method.IsPrivate)
                {
                    pravo = "private";
                }
                else if (method.IsFamily)
                {
                    pravo = "protected";
                }
                else if (method.IsPublic)
                {
                    pravo = "public";
                }
                Console.WriteLine($"Metoda ima {pravo} pravo pristupa");

                foreach (var parameters in method.GetParameters())
                {
                    Console.WriteLine($"{parameters.Name} {parameters.ParameterType}");
                }
                
            }
            // :134 Napisati petlju koja će za donju instancu klase Object ispisati imena svih njenih članova.
            object o = new object();
            Console.WriteLine($"*** Svi članovi instance klase {o.GetType().Name} ***");

            foreach (var member in o.GetType().GetMembers())
            {
                Console.WriteLine($"{member.Name}");
            }

            Console.ReadKey();
        }
    }
}
