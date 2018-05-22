using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        #region Class Members
        private const int k_BackChoiceIndex = 0;  // For Back (or Exit in case of MainMenu).
        private readonly string r_Back = "Back";
        private readonly List<MenuItem> r_ItemList;
        #endregion Class Members

        #region Constructors
        /* Default constructor for empty menu */
        public SubMenu()
        {
            r_ItemList = new List<MenuItem>();
        }

        public SubMenu(string i_Title)
        {
            r_ItemList = new List<MenuItem>();
            Title = i_Title;
        }
        #endregion Constructors

        #region Properties
        public List<MenuItem> ItemList
        {
            get { return r_ItemList; }
        }
        #endregion Properties

        #region Public & Internal Methods 
        /// <summary>
        /// Add a new menu item to this sub menu.
        /// if there are not items in the list add "Back" item option, and the new item.
        /// 
        /// </summary>
        /// <param name="i_MenuSubItemToAdd"></param>
        /// <returns></returns>
        public void Add(MenuItem i_MenuSubItemToAdd)
        {
            bool isFirstItemInList = ItemList.Count == 0;

            if (isFirstItemInList)
            {
                // Add "Back" item
                MenuItem backItem = new ActionItem
                {
                    Title = r_Back,
                    ItemIndex = k_BackChoiceIndex
                };

                ItemList.Add(backItem);
            }

            // Update item index for the given MenuItem
            i_MenuSubItemToAdd.ItemIndex = ItemList.Count;

            // Append the given MenuItem to this item list
            ItemList.Add(i_MenuSubItemToAdd);
        }

        internal override void DoWhenSelected()
        {
            if (ItemList.Count == 0)
            {
                Console.WriteLine("Item not initalized yet.");
            }
            else
            {
                showSubMenu();
            }
        }
        #endregion Public & Internal Methods 

        #region Private Methods
        private void showSubMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("-----------------------\n" + Title);
                printItemList();
                Console.WriteLine("-----------------------");
                choice = getChoiceFromUser();
                Console.Clear();
                if (choice != k_BackChoiceIndex)
                {
                    ItemList[choice].DoWhenSelected();
                }
            }
            while (choice != k_BackChoiceIndex);
        }

        private void printItemList()
        {
            List<MenuItem> listToPrint = new List<MenuItem>();
            string format = "{0}. {1}";

            foreach (MenuItem item in ItemList)
            {
                if (item.ItemIndex != k_BackChoiceIndex)
                {
                    listToPrint.Add(item);
                }
            }

            foreach (MenuItem item in listToPrint)
            {
                Console.WriteLine(format, item.ItemIndex, item.Title);
            }
            // Print the BackItem last
            Console.WriteLine(format, ItemList[0].ItemIndex, ItemList[0].Title);
        }

        private int getChoiceFromUser()
        {
            int choice;
            string choiceString;

            Console.Write("Choice Index: ");
            choiceString = Console.ReadLine();

            while (!int.TryParse(choiceString, out choice) || (choice < 0 || choice > ItemList.Count - 1))
            {
                Console.Write("Please enter a number between {0} and {1}:", 0, ItemList.Count - 1);
                choiceString = Console.ReadLine();
            }

            return choice;
        }
        #endregion Private Mehods
    }
}

