using System;

namespace LoopAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestada PIN-kood 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood om mingi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //Kasutajal on kolm katsest. i < 3

            int i = 0; //i - interation

            while(i <3) //While-loop
            {

                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i++; // i = i + 1
                    Console.WriteLine($"Vale PIN. {3 - i} katkset on jäänud.");
                }

                
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
