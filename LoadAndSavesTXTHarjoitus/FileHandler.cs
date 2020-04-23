using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LoadAndSavesTXTHarjoitus
{
    public class FileHandler
    {
        //public string filePath = @"G:\Diginikkarit\Harjoitusfiluja\LoadAndSaveTXT\TestData.txt";
        //public string thisFile = @"TestData.txt";
        public List<string> lines = new List<string>();

        //public string currentPath { get; set; }
        //public string currentFile { get; set; }



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
            string playerString = Convert.ToString($"{player.Name},{player.Gold},{player.EXP},{player.IsAlive}");
            return playerString;
        }

        public void WriteLineToFile(List<string> lines)
        {
            SaveToFiles(lines);
        }

        public void PlayersToLines(List<Player> players)
        {
            foreach (var player in players)
            {
                lines.Add(PlayerToString(player));
            }
        }

        public void DoTheThing(List<Player> players)
        {
            foreach (var player in players)
            {
                PlayerToString(player); 
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
                string[] entries = line.Split(",");
                player.Name = entries[0];
                player.EXP = Convert.ToInt32(entries[1]);
                player.Gold = Convert.ToInt32(entries[2]);
                player.IsAlive = Convert.ToBoolean(entries[3]);
            }
            return player;
        }

        public string GetCurrentFilePath()
        {
            return currentPath + currentFile;
        }

        public List<Player> LoadPlayerDataFromCurrentFile()
        {
            List<string> rows = LoadDataFromFile(GetCurrentFilePath());
            List<Player> players = new List<Player>();
            foreach (var row in rows)
            {
                players.Add(StringToPlayer(row));
            }
            return players;
        }
    }
}
