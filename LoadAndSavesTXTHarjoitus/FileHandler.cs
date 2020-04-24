using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LoadAndSavesTXTHarjoitus
{
    public class FileHandler
    {
        public List<string> lines = new List<string>();

        private string curPath;

        public string currentPath
        {
            get { return curPath; }
            set { curPath = value; }
        }

        private string curFile;

        public string currentFile
        {
            get { return curFile; }
            set { curFile = value; }
        }

        public void SaveToFiles(List<string> lines)
        {
            File.WriteAllLines(GetCurrentFilePath(), lines);
        }

        public void LoadFromFiles(string file)
        {
            lines = File.ReadAllLines(file).ToList();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }

        public string PlayerToString(Player player)
        {
            if (player == null)
            {
                Console.WriteLine("Error, player was null!");
                return null;
            }
            else
            {
                string playerString = Convert.ToString($"{player.Name},{player.Gold},{player.EXP},{player.IsAlive}");
                return playerString; 
            }
        }

        public void WriteLineToFile(List<string> lines)
        {
            SaveToFiles(lines);
        }

        public void PlayersToLines(List<Player> players)
        {
            foreach (var player in players)
            {
                if (player == null)
                {
                    Console.WriteLine("Error, player data was null!");
                }
                else
                {
                    lines.Add(PlayerToString(player)); 
                }
            }
        }

        public void DoTheThing(List<Player> players)
        {
            foreach (var player in players)
            {
                if (player == null)
                {
                    Console.WriteLine("Error, player data was null!");
                }
                else
                {
                    PlayerToString(player); 
                } 
            }
            PlayersToLines(players);
            WriteLineToFile(lines);
        }

        public List<string> LoadDataFromFile(string file)
        {
            LoadFromFiles(file);
            return lines;
        }

        public Player StringToPlayer(string thisFile)
        {
            Player player = new Player();
            foreach (var line in lines)
            {
                if (line == null)
                {
                    Console.WriteLine("Error, empty line!");
                    return null;
                }
                else
                {
                    string[] entries = line.Split(",");
                    player.Name = entries[0];
                    player.EXP = Convert.ToInt32(entries[1]);
                    player.Gold = Convert.ToInt32(entries[2]);
                    player.IsAlive = Convert.ToBoolean(entries[3]); 
                }
            }
            return player;
        }

        public string GetCurrentFilePath()
        {
            return currentPath + currentFile;
        }

        public List<Player> LoadPlayerDataFromCurrentFile()
        {
            try
            {
                List<string> rows = LoadDataFromFile(GetCurrentFilePath());
                List<Player> players = new List<Player>();
                foreach (var row in rows)
                {
                    players.Add(StringToPlayer(row));
                }
                return players;
            }
            catch (Exception)
            {
                Console.WriteLine($"Error, no players in {currentFile}");
                Console.ReadKey();
                return null;
            }
        }

        public string ChangeCurrentFile()
        {
            do
            {
                if (currentFile == null)
                {
                    Console.WriteLine("Error, name can't be null!");
                }
                Console.WriteLine($"Current file path: {currentPath}");
                Console.WriteLine($"Current file name: {currentFile}");
                Console.WriteLine($"Create a new file name: ");             //new .txt where players will be saved
                currentFile = (Console.ReadLine().ToLower().Trim()); 
            } while (currentFile == null);
            return currentFile;
        }
    }
}
