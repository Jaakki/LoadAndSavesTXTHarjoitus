using System;
using System.Collections.Generic;
using System.Text;

namespace LoadAndSavesTXTHarjoitus
{
    public class Player
    {
        public int EXP { get; set; }
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Gold { get; set; }

        public static Player CreatePlayer()                                 //give values to a player object, then return player
        {
            Player player = new Player();
            Console.WriteLine("Character name: ");
            player.Name = Console.ReadLine();
            Console.WriteLine("Starting experience: ");
            player.EXP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Starting gold: ");
            player.Gold = Convert.ToInt32(Console.ReadLine());
            player.IsAlive = true;
            return player;
        }

        public static void DisplayPlayers(List<Player> players)             //prints player info in this format
        {
            foreach (Player player in players)
            {
                Console.WriteLine($"Player name: {player.Name} - Experience: {player.EXP} - Player Gold: {player.Gold} - Player is alive? {player.IsAlive}");
            }
            Console.ReadLine();
        }
    }
}
