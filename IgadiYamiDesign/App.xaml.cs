using IgadiYamiDesign.Pages;

namespace IgadiYamiDesign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           // MainPage = new StartPage();
            // Set the theme based on system settings
            App.Current.UserAppTheme = App.Current.RequestedTheme;

            MainPage = new AboutUs();
           // MainPage = new NavigationPage(new AboutUs());
        }
    }
}
