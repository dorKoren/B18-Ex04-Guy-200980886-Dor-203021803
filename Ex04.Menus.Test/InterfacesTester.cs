using System;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public static class InterfacesTester
    {
        public static void RunInterfacesMenu()
        {
            MainMenu mainMenu = buildInterfacesMenu();
            mainMenu.Show();
        }

        private static MainMenu buildInterfacesMenu()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.MainMenuItems.Title = " Main Menu (Interfaces) ";

            SubMenu dateAndTime = new SubMenu("Show Date/Time");
            dateAndTime.Add(new ActionItem("Show Time", new Options.Time()));
            dateAndTime.Add(new ActionItem("Show Date", new Options.Date()));
            mainMenu.Add(dateAndTime);

            SubMenu versionAndCapitals = new SubMenu("Version and Capitals");
            versionAndCapitals.Add(new ActionItem("Count Capitals", new Options.CountCapitals()));
            versionAndCapitals.Add(new ActionItem("Show Version", new Options.ShowVersion()));
            mainMenu.Add(versionAndCapitals);

            return mainMenu;
        }
    }
}
