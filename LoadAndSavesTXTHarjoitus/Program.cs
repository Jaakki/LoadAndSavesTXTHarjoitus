using System;
using System.Collections.Generic;

namespace LoadAndSavesTXTHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu.MainMenu();
            }
        }
    }
}
