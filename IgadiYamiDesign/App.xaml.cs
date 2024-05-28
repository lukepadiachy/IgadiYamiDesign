using IgadiYamiDesign.Pages;

namespace IgadiYamiDesign
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();
          

            InitializeComponent();
            MainPage = new CommunityChatView();
            // Set the theme based on system settings
          //  App.Current.UserAppTheme = App.Current.RequestedTheme;

        }
    }
}
