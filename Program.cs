using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TaskGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Today we're playing forfeits.");
            int PlrsNmbr = SetPlayers.PlayersNr();
            List<string> PlrsNames = SetPlayers.PlayersNames(PlrsNmbr);
            PlayRound(PlrsNmbr, PlrsNames);
        }
        static void PlayRound(int number, List<string> players)
        {
            string[] quests = File.ReadAllLines("ListOfForfeits.txt", Encoding.Default);
            Console.WriteLine("Ok, all player's names are entered.");
            Random rnd = new Random();

            while (true)
            {
                Console.WriteLine("If you want to to see the names of all players, press 'p'; if you want to play, press any key; if you want to end the game, press 'q'");
                string ans = Console.ReadLine();
                if (ans == "q")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                else if (ans == "p")
                    for (int i = 0; i < number; i++)
                    {
                        Console.WriteLine(players[i]);
                    }
                else Console.WriteLine($"So, {players[rnd.Next(players.Count)]} should {quests[rnd.Next(quests.Length)]}!");
            }
        }
    }
}
