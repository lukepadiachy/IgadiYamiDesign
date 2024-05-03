using IgadiYamiDesign.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IgadiYamiDesign.ViewModels
{
	public partial class SignUpPageViewModel:BaseViewModel
	{
		private ISignUpService _signUpService;

		private string _emailAddress;

		public string EmailAddress
		{
			get => _emailAddress;
			set
			{
				_emailAddress = value;
				OnPropertyChanged();
			}
		}

		private bool _isEmailValid;

		public bool IsEmailValid
		{
			get => _isEmailValid;
			set
			{
				_isEmailValid = value;
				OnPropertyChanged();
			}
		}
		
		private string _password;

		public string Password
		{
			get => _password;
			set
			{
				_password = value;
				OnPropertyChanged();
			}
		}
		
		private bool _isPasswordValid;
		public bool IsPasswordValid
		{
			get { return _isPasswordValid; }
			set
			{
				_isPasswordValid = value;
				OnPropertyChanged();
			}
		}

		private string _confirmPassword;

		public string ConfirmPassword
		{
			get => _confirmPassword;
			set
			{
				_confirmPassword = value;
				OnPropertyChanged();
			}
		}

		private bool _isConfirmedPasswordValid;

		public bool IsConfirmedPasswordValid
		{
			get { return _isConfirmedPasswordValid; }
			set
			{
				_isConfirmedPasswordValid = value;

				OnPropertyChanged();
			}
		}

		private string _fullName;

		public string FullName
		{
			get { return _fullName; }
			set
			{
				_fullName = value;

				OnPropertyChanged();
			}
		}

		private bool _isFullNameValid;

		public bool IsFullNameValid
		{
			get { return _isFullNameValid; }
			set
			{
				_isFullNameValid = value;

				OnPropertyChanged();
			}
		}
	}
}
