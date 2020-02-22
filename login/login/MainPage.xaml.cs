using login.ViewModels;
using login.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace login
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

        }

        public async void GuardarValores()
        {
            usermanager manager = new usermanager();
            var res = await manager.getCuentaOscar();
            var res1 = await manager.getCuentaMarco();
            var res2 = await manager.getCuentaRaul();
            var res3 = await manager.getpassORM();


            if (usuario.Equals(res) && contraseña.Equals(res3))
            {
                await Navigation.PushAsync(new hola());
            }

            if (usuario.Equals(res1) && contraseña.Equals(res3))
            {
                await Navigation.PushAsync(new hola());
            }

            if (usuario.Equals(res2) && contraseña.Equals(res3))
            {
                await Navigation.PushAsync(new hola());
            }

            /*if (res != null)
            {
                usuario.BindingContext = res;
            }
            if (res1 != null)
            {
                usuario.BindingContext = res1;
            }
            if (res2 != null)
            {
                usuario.BindingContext = res2;
            }
            if (res3 != null)
            {
                contraseña.BindingContext = res3;
            }*/

        }


        private async void Registro_Clicked(object sender, EventArgs e)
		{
            await DisplayAlert("Usuario no valido", "Por favor ingrese un usuario valido", "ok");
        }




        private void Iniciar_Clicked(object sender, EventArgs e)
        {
            GuardarValores();
            
        }
    }
}
