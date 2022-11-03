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

            // Pokrenuti program i pogledati što će ispisati donja petlja.
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }

            Console.WriteLine($"*** Sve metode klase {t.Name} ***");

            // Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.
            //foreach (var mi in t.GetMethods())
            //{ 
            //    Console.WriteLine($"Ime: {mi.Name}, Povratni tip: {mi.ReturnType}");
            //}
            // Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).
            foreach (var mi in t.GetMethods())
            {
                Console.WriteLine($"Ime: {mi.Name}, Povratni tip: {mi.ReturnType}");
                foreach(var par in mi.GetParameters())
                {
                    Console.WriteLine($"\t\tTip: {par.ParameterType}, Ime: {par.Name}");
                }
            }
            // TODO:133 Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.

            // TODO:134 Napisati petlju koja će za donju instancu klase Object ispisati imena svih njenih članova.
            object o = new object();
            Console.WriteLine($"*** Svi članovi instance klase {o.GetType().Name} ***");

            Console.ReadKey();
        }
    }
}
