using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //Kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis selle numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib nubri ainult ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool katsed = true;

            

            while (katsed)
            {

                Console.WriteLine("Proovi arvata numbri. Sisesta number 1-10.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Õegesti! Sinu võit!");
                    katsed = false;
                }
                else
                {
                    Console.WriteLine("Vale, proovi uuesti");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
