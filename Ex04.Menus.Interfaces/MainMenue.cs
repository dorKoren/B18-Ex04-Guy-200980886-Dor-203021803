
namespace Ex04.Menus.Interfaces
{
    public class MainMenue
    {
        private readonly SubMenu r_MainItemsCollection;
        private readonly string r_Exit = "Exit";
        private readonly int r_ExitChoiceIndex = 0;

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
            if (MainItemsCollection.ItemList.Count == 2)   // Bag potential ?!
            {
                MainItemsCollection.ItemList[r_ExitChoiceIndex].Title = r_Exit;
            }
        }
 
        public void Show()
        {
            MainItemsCollection.DoWhenSelected();
        }
        #endregion Public Methods
    }
}
