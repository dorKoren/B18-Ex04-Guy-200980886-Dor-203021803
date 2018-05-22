using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Delegates;

    public static class DelegateTester
    {
        public static void RunDelegateMenu()
        {
            MainMenu mainMenu = buildDelegateMenu();
            mainMenu.Show();
        }

        private static MainMenu buildDelegateMenu()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.MainMenuItems.Title = " Main Menu (Delegate) ";

            SubMenu dateAndTime = new SubMenu("Show Date/Time");
            dateAndTime.Add(new ActionItem("Show Time", new Options.Time().Do));
            dateAndTime.Add(new ActionItem("Show Date", new Options.Date().Do));
            mainMenu.Add(dateAndTime);

            SubMenu versionAndCapitals = new SubMenu("Version and Capitals");
            versionAndCapitals.Add(new ActionItem("Count Capitals", new Options.CountCapitals().Do));
            versionAndCapitals.Add(new ActionItem("Show Version", new Options.ShowVersion().Do));
            mainMenu.Add(versionAndCapitals);

            return mainMenu;
        }
    }
}
