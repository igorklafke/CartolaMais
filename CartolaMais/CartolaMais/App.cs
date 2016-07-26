using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CartolaMais
{
    public class App : Application
    {
        public App()
        {
            //SE JÁ FOI FEITO LOGIN, REDIRECIONAR PARA A TELA INICIAL

            // The root page of your application
            Image imageCartolaMais = new Image
            {
                Source = "cartolafcmaislargo.png",
                WidthRequest = 120,
                HeightRequest = 40
            };
            Label bemVindo = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Bem vindo ao Cartola Mais!"
            };
            Label entrar = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Para entrar, efetue seu login no Cartola!"
            };
            Button btnLogin = new Button
            {
                BackgroundColor = Color.FromHex("FF6A00"),
                TextColor = Color.White,
                Text = "Login",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            btnLogin.Clicked += OnLogin;

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        imageCartolaMais,
                        bemVindo,
                        entrar,
                        btnLogin
                    }
                }
            };
        }

        public void OnLogin(object sender, EventArgs e)
        {
            var pagina = new Views.Login();
            MainPage = new NavigationPage(pagina);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
