using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MossPrice.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
            //Logo.Source = ImageSource.FromResource("/Asset/logochuan.png");
        }

        private void btn_login_Clicked(object sender, EventArgs e)
        {            
            Navigation.PushModalAsync(new Views.Home());
        }
    }
}