using IgadiYamiDesign.Pages;

namespace IgadiYamiDesign
{
    public partial class App : Application
    {
        public App()
        {
<<<<<<< HEAD
            InitializeComponent();
           // MainPage = new StartPage();
            // Set the theme based on system settings
            App.Current.UserAppTheme = App.Current.RequestedTheme;

            MainPage = new CreatAccount();
=======
             InitializeComponent();
            MainPage = new SettingsPage();
            // Set the theme based on system settings
            App.Current.UserAppTheme = App.Current.RequestedTheme;

            //MainPage = new StartPage();
>>>>>>> c1d00ce92c043daf40563a905076f87703029851
           // MainPage = new NavigationPage(new AboutUs());
        }
    }
}
