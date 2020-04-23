using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace LoadAndSavesTXTHarjoitus
{
    public class Menu
    {
        public static List<Player> players = new List<Player>();
        public static bool MainMenu(FileHandler fh)
        {
            BackToMenu:
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Create new player");
            Console.WriteLine("2) See all players");
            Console.WriteLine("3) Save player data to .txt");               //currently does not overwrite the existing data
            Console.WriteLine("4) Load player data from .txt");
            Console.WriteLine("5) Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    var player = Player.CreatePlayer();
                    players.Add(player);
                    return true;
                case "2":
                    Player.DisplayPlayers(players);
                    return true;
                case "3":
                    fh.DoTheThing(players);
                    return true;
                case "4":
                    fh.LoadPlayerDataFromCurrentFile();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        

    }
}
