
namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Title = string.Empty;
        private int m_ItemNumber = 0;

        internal abstract void DoWhenSelected();

        #region Properties
        internal int ItemNumber
        {
            get { return m_ItemNumber; }
            set { m_ItemNumber = value; }
        }

        internal string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }
        #endregion Properties
    }
}
