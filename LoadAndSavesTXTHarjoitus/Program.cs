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
            fh.currentFile = @"testdata.txt";

            //string juttu = fh.GetCurrentFilePath();
            //string asia = fh.filePath;

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu.MainMenu(fh);
            }
        }
    }
}
