using IgadiYamiDesign.Pages;

namespace IgadiYamiDesign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TomatoeView();
        }
    }
}
