using System;
using System.Collections.Generic;

namespace LoadAndSavesTXTHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler fh = new FileHandler();
            fh.currentPath = @"G:\Diginikkarit\Harjoitusfiluja\LoadAndSaveTXT\";
            fh.currentFile = @"TestData.txt";

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu.MainMenu();
            }
        }
    }
}
