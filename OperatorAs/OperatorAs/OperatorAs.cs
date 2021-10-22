using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Radnik : Osoba { }

    class Program
    {
        static void Main()
        {
            
            Pretvorba1();
            Pretvorba2();
            Pretvorba3();

            Console.ReadKey();
        }

        static void Pretvorba3()
        {
            // Pokrenuti program i provjeriti što će se ispisati te koja će iznimka biti bačena.
            Osoba janko = new Student();
            Student jankoStudent = janko as Student;
            if (jankoStudent != null)
                Console.WriteLine(jankoStudent);
            else
                Console.WriteLine("null");

            Radnik jankoSljaker = janko as Radnik;
            if (jankoSljaker != null)
                Console.WriteLine(jankoSljaker);
            else
                Console.WriteLine("null");

            try
            {
                jankoSljaker = (Radnik)janko;
            }
            catch (Exception e)
            {
                Console.WriteLine("Bačena iznimka!");
                Console.WriteLine(e.Message);
            }

        }

        // Pogledati donje pretvorbe i razjasniti razliku.

        // ovo je česti način pisanja kada želimo napraviti "sigurnu" pretvorbu:
        static void Pretvorba1()
        {
            Console.WriteLine("Pretvorba 1");
            Osoba janko = new Student();

            if (janko is Student)
            {
                Student studentJanko = (Student)janko;
                // iskoristi studenta unutar bloka
            }
        }

        // ovo je efikasniji način pisanja kada želimo napraviti "sigurnu" pretvorbu:
        // (pogledati i usporediti generirani IL kod za obje metode)
        static void Pretvorba2()
        {
            Console.WriteLine("Pretvorba 2");
            Osoba janko = new Student();

            Student studentJanko = janko as Student;
            if (studentJanko != null)
            {
            }
        }
    }
}
