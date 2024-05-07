using IgadiYamiDesign.Modelss.Carrot;
using IgadiYamiDesign.Servicess;
using System.Collections.ObjectModel;

namespace IgadiYamiDesign
{
    public partial class MainPage : ContentPage
    {
        private PlantDatabase _database;

        private string _displaydiseasename;

        public string DisplayDiseaseName
        {
            get { return _displaydiseasename; }
            set { _displaydiseasename = value; }
        }


        private Carrot _carrot;
        public Carrot CarrotInfo
        {
            get { return _carrot; }
            set { _carrot = value; }
        }


        public MainPage()
        {
            InitializeComponent();
            _database = new PlantDatabase();
            BindingContext = this;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            LoadData();
        }
        public void LoadData()
        {
            CarrotInfo = _database.GetCarrotInformation();

            string test = "Carrot Rust Fly";
            CarrotDisease carrotrustfly = _database.GetCarrotDiseaseByName(test);
            DisplayDiseaseName = carrotrustfly.DiseaseName;
            // Returns a list from the database with all data and displays in one the screen
            //CartItems = new ObservableCollection<ShoppingCart>(_database.GetAllCartItems());
        }
    }
}
