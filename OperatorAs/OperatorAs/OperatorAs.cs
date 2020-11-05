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
            //  Pokrenuti program i provjeriti što će se ispisati te koja će iznimka biti bačena.
            Osoba janko = new Student();
            Student jankoStudent = janko as Student;
            if (jankoStudent != null)
                Console.WriteLine(jankoStudent);
            else
                Console.WriteLine("null");

            Radnik jankoSljaker = janko as Radnik;//ne uspije
            if (jankoSljaker != null)
                Console.WriteLine(jankoSljaker);
            else
                Console.WriteLine("null");

            try
            {
                jankoSljaker = (Radnik)janko;//nije dozvoljeni cash
            }
            catch (Exception e)
            {
                Console.WriteLine("Bačena iznimka!");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        //  Pogledati donje pretvorbe i razjasniti razliku.

        // ovo je česti način pisanja kada želimo napraviti "sigurnu" pretvorbu:
        static void Pretvorba1()
        {
            Osoba janko = new Student();//bazni se pokusava pridruziti izvedeno
            //tu se prvo radi cash pa provjera
            if (janko is Student)//provjera ce proci jer je u tipu student
            {
                Student studentJanko = (Student)janko;
                // iskoristi studenta unutar bloka
            }
        }

        // ovo je efikasniji način pisanja kada želimo napraviti "sigurnu" pretvorbu:
        // (pogledati i usporediti generirani IL kod za obje metode)
        static void Pretvorba2()
        {
            Osoba janko = new Student();
            //tu se pomocu as pokusa napraviti cash tj pretvorbu i vraca je na stvarni mjestio i efikasniji je
            Student studentJanko = janko as Student;//as ce pokusati napraviti cash 
            if (studentJanko != null)
            {
            }
        }
    }
}
