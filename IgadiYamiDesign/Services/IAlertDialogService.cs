using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgadiYamiDesign.Services
{
	public interface IAlertDialogService
	{
	  Task ShowAlertAsync(string title, string message, string cancel = "OK");
		
	}
}
