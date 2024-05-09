namespace IgadiYamiDesign.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private void Login_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new TomatoeView());
    }

}
