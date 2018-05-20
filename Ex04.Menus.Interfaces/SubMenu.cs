using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        #region Class Members
        private const int k_BackOptionNumber = 0;
        private readonly List<MenuItem> r_ItemList;
        #endregion Class Members

        #region Constructors
        public SubMenu()
        {
            r_ItemList = new List<MenuItem>();
        }

        public SubMenu(string i_Title)
        {
            r_ItemList = new List<MenuItem>();
            Title = i_Title;
        }

        public SubMenu(string i_Title, MenuItem i_MenuSubItem)
        {
            r_ItemList = new List<MenuItem>();
            Title = i_Title;
            Add(i_MenuSubItem);
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
        /// 
        /// </summary>
        /// <param name="i_MenuSubItemToAdd"></param>
        /// <returns></returns>
        public SubMenu Add(MenuItem i_MenuSubItemToAdd)
        {
            bool isFirstItemInList = ItemList.Count == 0;
            if (isFirstItemInList)
            {
                MenuItem backItem = new ActionItem
                {
                    Title = "Back",
                    ItemNumber = 0
                };

                ItemList.Add(backItem);
            }

            i_MenuSubItemToAdd.ItemNumber = ItemList.Count;

            ItemList.Add(i_MenuSubItemToAdd);

            return this;
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
                Console.WriteLine(Title.ToString());
                printItemList();
                choice = getChoiceFromUser();
                Console.Clear();
                if (choice != k_BackOptionNumber)
                {
                    ItemList[choice].DoWhenSelected();
                }
            }
            while (choice != k_BackOptionNumber);
        }

        private void printItemList()
        {
            List<MenuItem> listToPrint = new List<MenuItem>();
            string format = "{0}. {1}";

            foreach (MenuItem item in ItemList)
            {
                if (!(item.ItemNumber == k_BackOptionNumber))
                {
                    listToPrint.Add(item);
                }
            }

            foreach (MenuItem item in listToPrint)
            {
                Console.WriteLine(format, item.ItemNumber.ToString(), item.Title.ToString());
            }

            Console.WriteLine(format, ItemList[0].ItemNumber.ToString(), ItemList[0].Title.ToString());
        }

        private int getChoiceFromUser()
        {
            int choice;
            string choiceString;

            Console.Write("Option #: ");
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
