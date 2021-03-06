﻿using System;

namespace Ex04.Menus.Delegates
{
    public class ActionItem : MenuItem
    {
        public delegate void ActionDelegate();

        public event ActionDelegate ActionToDoWhenSelected;

        #region Constructor
        public ActionItem()
        {
            ActionToDoWhenSelected = null;
        }      

        public ActionItem(string i_Title, ActionDelegate i_ActionDelegate)
        {
            Title = i_Title;
            ActionToDoWhenSelected += i_ActionDelegate;
        }
        #endregion Constructors

        #region Methods
        internal override void DoWhenSelected()
        {
            if (ActionToDoWhenSelected != null)
            {
                ActionToDoWhenSelected.Invoke();
            }
            else
            {
                Console.WriteLine("Nothing to do when selected, event holds no refrences.");
            }
        }
        #endregion Methods
    }
}