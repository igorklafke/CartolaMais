﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CartolaMais.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        public void OnEntrar(object sender, EventArgs e)
        {
            var pagina = new Views.MenuPage();
            Navigation.PushAsync(pagina);
        }
    }
}
