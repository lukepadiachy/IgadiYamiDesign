namespace IgadiYamiDesign.Pages;

public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();


    }
    private void SignUp_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new LoginPage());
    }


    private void Login_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new LoginPage());
    }

    void OnGoogleGestureRecognizerTapped(object sender, TappedEventArgs args)
    {
        // Handle the tap
    }
    void OnMicrosoftGestureRecognizerTapped(object sender, TappedEventArgs args)
    {
        // Handle the tap
    }
}
