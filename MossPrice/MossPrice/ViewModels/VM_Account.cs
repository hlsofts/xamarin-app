using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using MossPrice.Models;
using Xamarin.Forms;

namespace MossPrice.ViewModels
{
    public class VM_Account : BaseViewModel
    {
        public Account Item { get; set; }
        public Command LoginCommand { get; set; }
        public VM_Account()
        {
            LoginCommand = new Command(async () => await HT_LOGIN());
        }

        private async Task HT_LOGIN()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                return;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
