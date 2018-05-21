

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private string m_Title = string.Empty;
        private int m_ItemIndex = 0;

        internal abstract void DoWhenSelected();

        internal int ItemIndex
        {
            get { return m_ItemIndex; }
            set { m_ItemIndex = value; }
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }
    }
}
