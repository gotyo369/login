using System;
using System.Collections.Generic;
using System.Text;

namespace login.ViewModels
{
	class MainViewModel
	{
		#region ViewModels
		public loginViewModel login	{get; set;}

		#endregion

		#region ViewModels Constructores
		public MainViewModel()
		{
			this.login = new loginViewModel();
		}

	#endregion
}

}
