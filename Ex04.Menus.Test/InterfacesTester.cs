using System;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public static class InterfacesTester
    {
        public static void DemonstrateInterfacesMenu()
        {
            MainMenu mainMenu = buildInterfacesMenu();
            mainMenu.Show();
        }

        private static MainMenu buildInterfacesMenu()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.MainItemsCollection.Title = "*** Main Menu - Interfaces ***";

            SubMenu dateAndTime = new SubMenu("Show Date/Time");
            dateAndTime.Add(new ActionItem("Show Time", new Examples.Time()));
            dateAndTime.Add(new ActionItem("Show Date", new Examples.Date()));
            mainMenu.Add(dateAndTime);

            SubMenu versionAndCapitals = new SubMenu("Version and Capitals");
            versionAndCapitals.Add(new ActionItem("Count Capitals", new Examples.CountCapitals()));
            versionAndCapitals.Add(new ActionItem("Show Version", new Examples.ShowVersion()));
            mainMenu.Add(versionAndCapitals);

            return mainMenu;
        }
    }
}
