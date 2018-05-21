﻿using System;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private IAction m_Action;

        #region Constructors
        public ActionItem()
        {
            m_Action = null;
        }

        public ActionItem(string i_Title, IAction i_Action)
        {
            Title = i_Title;
            Action = i_Action;
        }
        #endregion Constructors

        #region Properties
        public IAction Action
        {
            get { return m_Action; }
            set { m_Action = value; }
        }
        #endregion Properties

        #region Internal Methods
        internal override void DoWhenSelected()
        {
            if (Action == null)
            {
                Console.WriteLine("Item not initalized yet.");
            }
            else
            {
                Action.Do();
            }
        }
        #endregion Internal Methods
    }
}