
namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private SubMenu m_MainMenu;
        private readonly string r_Exit = "Exit";
        private readonly int r_ExitChoiceIndex = 0;

        #region Constructor
        public MainMenu()
        {
            m_MainMenu = new SubMenu();
        }
        #endregion Constructor

        #region Properties 
        public SubMenu MainMenuItems
        {
            get { return m_MainMenu; }
        }
        #endregion Properties

        #region Public Methods
        public void Add(MenuItem i_Item)
        {
            MainMenuItems.Add(i_Item);
            if (MainMenuItems.ItemList.Count == 2)   // Bag potential ?!
            {
                MainMenuItems.ItemList[r_ExitChoiceIndex].Title = r_Exit;
            }
        }
 
        public void Show()
        {
            MainMenuItems.DoWhenSelected();
        }
        #endregion Public Methods
    }
}
