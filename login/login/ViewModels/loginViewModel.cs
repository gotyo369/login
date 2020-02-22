using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace login.ViewModels
{
	class loginViewModel
	{
		#region propiedades
		public String UsuarioOscar {get; set;}
		public String UsuarioMarco { get; set; }
		public String UsuarioRaul { get; set; }
		public String pass { get; set; }
		#endregion
		}
		/*#region constructores
		public loginViewModel()
		{

		}
		#endregion

		#region commands
		/*public ICommand LoginCommand
		{
			get
			{
				return new RelayCommand(login);
			}
		}
		private async void login()
		{
			if (string.IsNullOrEmpty(this.usuarios))
			{
				await Application.Current.MainPage.DisplayAlert("Usuario no valido", "Por favor ingrese un usuario valido", "ok");
				return;
			}

			if (string.IsNullOrEmpty(this.pass))
			{
				await Application.Current.MainPage.DisplayAlert("contraseña no valida", "Por favor ingrese una contraseña valida", "ok");
				return;
			}
		}
		#endregion*/
	
}
