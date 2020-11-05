using System;
using System.Reflection;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            Type t = typeof(System.DateTime);

            // ? Napisati petlju koja će za svaki član kojeg vrati metoda t.GetMembers ispisati ime tog člana.
                foreach (MemberInfo mi in t.GetMembers()) 
                Console.WriteLine($" {mi.Name}");

            // ? Dodati u petlji i ispis tipa svakog člana.
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }


            // ? Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.
            foreach (MethodInfo mi in t.GetMethods())
                Console.WriteLine($"{mi.Name} {mi.ReturnType.ToString()}");

                // ? Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).

                // ? Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.
                foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.ReturnType.ToString()} {mi.Name}");
                
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType.ToString()} {parameter.Name} ");
                    
                }
                if (mi.IsPublic == true)
                    Console.WriteLine($"Public");
                else if (mi.IsPrivate == true)
                    Console.WriteLine($"Private");
                else
                    Console.WriteLine($"Protected");
                //ako su sve metode koje vraća  t.GetMethods() public, tada je ok da za sve stoji da su public jer meni tako stoji. 
                //sve metode u strukturi DateTime za Type t = typeof(System.DateTime); su public 
                //TODO:140 Profesore da li je takav ispis ispravan?  
                //Pusham i pullam ako je to to.
            }

            Console.ReadKey();
        }
    }
}
