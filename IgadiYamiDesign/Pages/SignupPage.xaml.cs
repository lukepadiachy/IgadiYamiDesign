using IgadiYamiDesign.ViewModels;

namespace IgadiYamiDesign.Pages;

public partial class SignupPage : ContentPage
{
	public SignupPage(SignUpPageViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}