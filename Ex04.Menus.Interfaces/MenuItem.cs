
namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        #region Class Members
        private string m_Title = string.Empty;
        private int m_ItemIndex = 0;
        #endregion Class Members 

        internal abstract void DoWhenSelected();

        #region Properties
        internal int ItemIndex
        {
            get { return m_ItemIndex; }
            set { m_ItemIndex = value; }
        }

        internal string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }
        #endregion Properties
    }
}
