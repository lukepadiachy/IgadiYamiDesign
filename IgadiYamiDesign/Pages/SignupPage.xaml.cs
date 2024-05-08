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
}