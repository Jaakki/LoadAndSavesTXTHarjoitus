using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LoadAndSavesTXTHarjoitus
{
    public class FileHandler
    {
        public string filePath = @"G:\Diginikkarit\Harjoitusfiluja\LoadAndSaveTXT\TestData.txt";
        public List<string> lines = new List<string>();

        public void SaveToFiles(List<string> lines)
        {
            File.WriteAllLines(filePath, lines);
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

        public List<string> LoadData(string filePath)
        {
            LoadFromFiles(filePath);
            return lines;
        }
    }
}
