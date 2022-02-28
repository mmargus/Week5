using System;

namespace ORoperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, kasutajal sisestada kasutaja tunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast";
            //muidu konsoolis kuvatakse "Vale kasutajanimi või salasõna. Proovi uuesti."
            //OR (või) || (pipes)

            // true || true -->
            // false true || --> true
            //true false || --> true
            // false false || --> false 

            Console.Write("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.Write("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if (userName != "admin" || userPassword != "admin1234")
            //! ei
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            //Kasutaja sisestas "admin1" mis ei = "admin"
            //"admin1" ! ="admin" || "admin1234" ! == "admin1234" --> true || false --> true
            //"admin" != "admin" || "admin123" != ""admin1234" --> false || true --> true
            //"admin1" != "admin" || "admin123" != "admin1234" --> true || true --> true
            //"admin" != "admin" || "admin1234" != "admin1234" --> false || false --> false
            
            

        }
    }
}
