using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Provider.ContactsContract;

namespace IgadiYamiDesign.Services
{
	public interface ISignUpService
	{
		void Save(Profile profile);
	}
}
