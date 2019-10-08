using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TaskGame2
{
    public class SetPlayers
    {
        public static int PlayersNr()
        {
            GiveAnswer();
            string inputNr = (Console.ReadLine());
            int.TryParse(inputNr, out int actNumber);
            while (true)
            {
                if (actNumber < 2 || actNumber > 10)
                {
                    Console.WriteLine("Sorry, there's too many or too little of you.");
                    GiveAnswer();
                }
                else if (Enumerable.Range(2, 10).Contains(actNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You should enter a number of players.");
                    GiveAnswer();
                }
            }
            return actNumber;
        }
        public static void GiveAnswer()
        {
            Console.WriteLine("We need 2-10 players. How many of you are here now?");
        }
        public static List<string> PlayersNames(int playerCount)
        {
            List<string> player = new List<string>();
            Console.WriteLine($"Ok! I see that there are {PlayersNr()} of you. Enter your names, please");
            for (int counter = 0; counter < playerCount; counter++)
            {
                player.Add(Console.ReadLine());
            }
            return (player);
        }
    }
}
