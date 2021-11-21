using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on  mängu võitnud;
            //katsete arv on piiramatu
            //*programm genereerib juhuslikku numbrit vaid ühte korda

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Arva numbrit 1 kuni 10:");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                i++;

                if (userGuess == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, sa arvasid õigesti!"); ;
                    loopActive = false;
                }
                else 
                {
                    Console.WriteLine($"Oled arvanud {i} korda valesti.");
                }
            }
        }
    }
}
