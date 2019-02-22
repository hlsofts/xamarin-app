using MossPrice.Models;
using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MossPrice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeDetail : ContentPage
    {
        public HomeDetail()
        {
            InitializeComponent();
            BindingContext = new ViewModels.VM_ListOrders();            
        }

        private void LstOrder_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var content = e.Item as Customer;
        }

        private void Btn_search_Clicked(object sender, EventArgs e)
        {
            //p_search.IsVisible = true;
        }

        private void Btn_searching_Clicked(object sender, EventArgs e)
        {
            //p_search.IsVisible = false;
            CrossToastPopUp.Current.ShowToastMessage("Tổng số 12012 bản ghi");
        }
    }
}