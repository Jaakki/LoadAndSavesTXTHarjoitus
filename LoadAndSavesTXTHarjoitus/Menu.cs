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
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Create new player");
            Console.WriteLine("2) See all players");
            Console.WriteLine("3) Save player data to .txt");
            Console.WriteLine("4) Load player data from .txt");
            Console.WriteLine("5) Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    var p = Player.CreatePlayer();
                    players.Add(p);
                    return true;
                case "2":
                    Player.DisplayPlayers(players);
                    return true;
                case "3":
                    var save = new FileHandler();
                    save.DoTheThing(Menu.players);
                    return true;
                case "4":
                    var load = new FileHandler();
                    load.LoadData(load.filePath);
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        

    }
}
