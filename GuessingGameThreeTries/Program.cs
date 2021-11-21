using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on  mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata 
            //siis mängu võidab arvuti
            //*programm genereerib juhuslikku numbrit vaid ühte korda

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Arva numbrit 1 kuni 10:");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                i++;
                if (userGuess == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, sa arvasid õigesti!");
                    break;
                }
                Console.WriteLine($"Vale number. Sul on jäänud {3 - i} katset.");
                
                if (i == 3)
                {
                    Console.WriteLine("Sinu katsete arv on täis. Arvuti võitis seekord.");
                }
               
                
            }

        }
    }
}
