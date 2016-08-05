using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartolaMais.Models;

using Xamarin.Forms;

namespace CartolaMais.Views
{
    public partial class MenuPage : MasterDetailPage
    {
        MasterPage masterPage;

        public MenuPage()
        {
            masterPage = new MasterPage();
            masterPage.ListView.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MasterPageItem);
            Master = masterPage;
            Detail = new NavigationPage(new HomePage());

            MasterBehavior = MasterBehavior.Popover;
        }
        
        void NavigateTo(MasterPageItem item)
        {
            if(item != null)
            {
                Page displayPage = (Page)Activator.CreateInstance(item.TargetType);
                Detail.Navigation.PushAsync(displayPage);
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
