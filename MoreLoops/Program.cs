using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, kasutajal sisestada kasutaja tunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast";
            //muidu konsoolis kuvatakse "Vale kasutajanimi või salasõna. Proovi uuesti."

            Console.Write("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.Write("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            //AND 
            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin12345" --> false
            //"admin1" AND "admin123" --> false

            //AND (&&) või OR

            if(userName == "admin" && userPassword == "admin1234")
                    { Console.Write("Tere tulemast!");
            }
            else
            { Console.Write("Vale kasutajatunnus või parool. Proovi uuesti.");
            }
        }
    }
}
