using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //Kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis selle numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on 3.
            //siis kui kasutaja ei suuda numbrit arvata, siis arvuti võidab
            //*programm genereerib nubri ainult ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {

                Console.WriteLine("Proovi arvata numbri. Sisesta number 1-10.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Õegesti! Sinu võit!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale. On jäänud {3 - i} katseid.");
                }
                Console.WriteLine("Kena päeva!");

            }
        }
    }
}
