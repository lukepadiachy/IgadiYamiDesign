namespace IgadiYamiDesign.Pages;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();

        // Initialize the switch state based on the current theme
        bool isDarkMode = App.Current.RequestedTheme == AppTheme.Dark;
        // Find the switch in the layout and set its state
        var darkModeSwitch = this.FindByName<Switch>("DarkModeSwitch");
       // darkModeSwitch.IsToggled = isDarkMode;
    }

    private async void OnEditProfileClicked(object sender, EventArgs e)
    {
        // Handle Edit profile click event
        await DisplayAlert("Edit Profile", "Edit profile clicked", "OK");
    }

    private async void OnPremiumTabClicked(object sender, EventArgs e)
    {
        // Handle Premium Tab click event
        await DisplayAlert("Premium Tab", "Premium tab clicked", "OK");
    }

    private async void OnFAQClicked(object sender, EventArgs e)
    {
        // Handle FAQ click event
        await DisplayAlert("FAQ", "FAQ clicked", "OK");
    }

    private async void OnHelpClicked(object sender, EventArgs e)
    {
        // Handle Help click event
        await DisplayAlert("Help", "Help clicked", "OK");
    }

    private async void OnAboutUsClicked(object sender, EventArgs e)
    {
        // Handle About Us click event that routes to the about us page
        await Navigation.PushAsync(new AboutUs());
    }

    private async void OnTermsAndConditionsClicked(object sender, EventArgs e)
    {
        // Handle Terms and Conditions click event
        await DisplayAlert("Terms and Conditions", "Terms and conditions clicked", "OK");
    }

    private void OnDarkModeToggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            // Set Dark Mode
            App.Current.UserAppTheme = AppTheme.Dark;
        }
        else
        {
            // Set Light Mode
            App.Current.UserAppTheme = AppTheme.Light;
        }
    }
}
