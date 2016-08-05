using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CartolaMais.Views
{
    public partial class Configuracao : ContentPage
    {
        public Configuracao()
        {
            Label header = new Label
            {
                Text = "Configurações de alerta do aplicativo",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            SwitchCell switchJogadoresNaoProvaveis = new SwitchCell();
            switchJogadoresNaoProvaveis.Text = "Jogadores escalados não prováveis:";
            switchJogadoresNaoProvaveis.OnChanged += (sender, e) => OnChanged(sender, e);

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection
                    {
                        switchJogadoresNaoProvaveis
                    }
                }
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    tableView
                }
            };
        }

        void OnChanged(object sender, EventArgs e)
        {            //Evento ao alterar campo Switch
        }
    }
}
