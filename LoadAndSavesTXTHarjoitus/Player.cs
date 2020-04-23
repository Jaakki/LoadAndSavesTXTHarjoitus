﻿using System;
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
            int invalidInt;
            string validateString;
            Player player = new Player();
            Console.WriteLine("Character name: ");
            player.Name = Console.ReadLine();
            while (string.IsNullOrEmpty(player.Name))
            {
                Console.WriteLine("Invalid name given!\nEnter a new name:");
                player.Name = Console.ReadLine();
            }
            Console.WriteLine("Starting experience: ");
            validateString = (Console.ReadLine()+0);
            while (!int.TryParse(validateString, out invalidInt))
            {
                Console.WriteLine("Invalid value!\nEnter a new value:");
                validateString = Console.ReadLine();
            }
            player.EXP = Convert.ToInt32(validateString);
            Console.WriteLine("Starting gold: ");
            validateString = (Console.ReadLine() + 0);
            while (!int.TryParse(validateString, out invalidInt))
            {
                Console.WriteLine("Invalid value!\nEnter a new value:");
                validateString = Console.ReadLine();
            }
            player.Gold = Convert.ToInt32(validateString);
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
