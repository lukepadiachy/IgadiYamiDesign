namespace IgadiYamiDesign.Pages;

public partial class LoginPage : ContentPage
{
    private const string HardcodedEmail = "test@example.com";
    private const string HardcodedPassword = "password123";

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void Login_Clicked(object sender, EventArgs e)
    {
        string email = emailEntry.Text;
        string password = passwordEntry.Text;

        if (email == HardcodedEmail && password == HardcodedPassword)
        {
            await DisplayAlert("Login Success", "You have successfully logged in.", "OK");
            await Navigation.PushModalAsync(new MainMenu());
        }
        else
        {
            await DisplayAlert("Login Failed", "Incorrect email or password. Please try again.", "OK");
        }

    }
}
