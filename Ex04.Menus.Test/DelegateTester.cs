using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Delegates;

    public static class DelegateTester
    {
        public static void DemonstrateDelegateMenu()
        {
            MainMenu mainMenu = buildDelegateMenu();
            mainMenu.Show();
        }

        private static MainMenu buildDelegateMenu()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.MainItemsCollection.Title = "*** Main Menu - Delegate ***";

            SubMenu dateAndTime = new SubMenu("Show Date/Time");
            dateAndTime.Add(new ActionItem("Show Time", new Examples.Time().DoIt));
            dateAndTime.Add(new ActionItem("Show Date", new Examples.Date().DoIt));
            mainMenu.Add(dateAndTime);

            SubMenu versionAndCapitals = new SubMenu("Version and Capitals");
            versionAndCapitals.Add(new ActionItem("Count Capitals", new Examples.CountCapitals().DoIt));
            versionAndCapitals.Add(new ActionItem("Show Version", new Examples.ShowVersion().DoIt));
            mainMenu.Add(versionAndCapitals);

            return mainMenu;
        }
    }
}
