using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenue
    {
        #region Read Only Members
        private readonly SubMenu r_MainItemsCollection;
        #endregion  Read Only Members

        #region Constructor
        public MainMenue()
        {
            r_MainItemsCollection = new SubMenu();
        }
        #endregion Constructor

        #region Properties 
        public SubMenu MainItemsCollection
        {
            get { return r_MainItemsCollection; }
        }
        #endregion Properties

        #region Public Methods
        public void Add(MenuItem i_Item)
        {
            MainItemsCollection.Add(i_Item);
            if (MainItemsCollection.ItemList.Count == 2)
            {
                MainItemsCollection.ItemList[0].Title = "Exit";
            }
        }
 
        public void Show()
        {
            MainItemsCollection.DoWhenSelected();
        }

        #endregion Public Methods
    }
}
