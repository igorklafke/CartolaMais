using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartolaMais.Services;
using Xamarin.Forms;

namespace CartolaMais.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

		public async void OnEntrar(object sender, EventArgs e)
        {
			//var pagina = new Views.Login();
			//MainPage = new NavigationPage(pagina);
			Cartola cartolaService = new Cartola();
			string result = await cartolaService.Autenticar(email.Text, senha.Text);

			await DisplayAlert("Auth", result, "ok");
            var pagina = new Views.MenuPage();
            Navigation.PushAsync(pagina);
        }
    }
}
