using IgadiYamiDesign.Pages;

namespace IgadiYamiDesign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SettingsV2();
            // Set the theme based on system settings
            App.Current.UserAppTheme = App.Current.RequestedTheme;
        }
    }
}
