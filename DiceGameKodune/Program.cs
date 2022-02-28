using System;

namespace DiceGameKodune
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb viskas rohkem
            //mängija kes viskas rohkem, ongi võitja
            //mõlemad viskavad täringuid kolm korda
            //programm kuvab võitjat
            //random - juhuslik numbe

            Random rnd = new Random();

            int userScore = 0;
            int CPUScore = 0;
            for (int i = 0; i < 6; i++)
            {

                int CPURandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti viskas: {CPURandom}");
                Console.WriteLine($"Kasutaja viskas: {userRandom}");
                if (CPURandom < userRandom)
                {
                    Console.WriteLine("Võitsid mängu.");
                    userScore++;
                }
                else if (CPURandom > userRandom)
                {
                    Console.WriteLine("Arvuti võitis.");
                    CPUScore++;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }

            }
            
            else if (CPUScore > userScore)
            {
                Console.WriteLine($"Arvuti võitis seeria {CPUScore} : {userScore}");
            }
            else
            {
                Console.WriteLine("Uskumatu lugu, jäite viiki!");
            }






        }
    }
}
