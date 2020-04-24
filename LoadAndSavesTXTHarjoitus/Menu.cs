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
            
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Create new player");
            Console.WriteLine("2) See all players");
            Console.WriteLine($"3) Save player data to {fh.currentFile}");               //currently does not overwrite the existing data
            Console.WriteLine($"4) Load player data from {fh.currentFile}");
            Console.WriteLine("5) Create a new file for players");
            Console.WriteLine("6) Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    var player = Player.CreatePlayer();
                    if (player == null)
                    {
                        Console.WriteLine("Player info was not added, because player was empty!");
                        Console.ReadKey();
                    }
                    else
                    {
                        players.Add(player); 
                    }
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
                    fh.ChangeCurrentFile();
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }

        

    }
}
