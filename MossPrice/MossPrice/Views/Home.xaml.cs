using MossPrice.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MossPrice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : MasterDetailPage
    {
        public Home()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            HomeMenuItem item = e.SelectedItem as HomeMenuItem;
            if (item == null)
            {
                return;
            }

            Page page = null;
            switch (item.Id)
            {
                case (int)MenuItemType.ListOrders:
                    page = (Page)Activator.CreateInstance(typeof(Views.HomeDetail));
                    Detail = new NavigationPage(page);
                    page.Title = item.Title;
                    break;
                case (int)MenuItemType.DetailOrders:
                    page = (Page)Activator.CreateInstance(typeof(Views.ListOrders));
                    Detail = new NavigationPage(page);
                    page.Title = item.Title;
                    break;
                case (int)MenuItemType.About:
                    page = (Page)Activator.CreateInstance(typeof(Views.About));
                    Detail = new NavigationPage(page);
                    page.Title = item.Title;
                    break;
                case (int)MenuItemType.Exit:
                    Navigation.PushModalAsync(new Views.Login());
                    break;
            }

            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }
    }
}