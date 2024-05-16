using IgadiYamiDesign.Pages;

namespace IgadiYamiDesign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set the theme based on system settings
            App.Current.UserAppTheme = App.Current.RequestedTheme;

            MainPage = new TomatoeView();
            MainPage = new NavigationPage(new AboutUs());
        }
    }
}
