using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MossPrice
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            Resources = new ResourceDictionary
            {
                { "primaryGreen", Color.FromHex(Commons.Constants.MOSS_COLOR) },
                { "primaryDarkGreen", Color.FromHex(Commons.Constants.MOSS_COLOR) },
                { "colorAccent", Color.FromHex(Commons.Constants.COLOR_ACCENT) }
            };
            
            MainPage = new Views.Login();
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
