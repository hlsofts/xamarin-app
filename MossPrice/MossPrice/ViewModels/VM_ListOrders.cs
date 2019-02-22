using MossPrice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace MossPrice.ViewModels
{
    public class VM_ListOrders
    {
        public ObservableCollection<Customer> ListCustomer { get; set; }
        public List<Customer> data { get; set; }
        public VM_ListOrders()
        {
            try
            {
                var datasource = LIST_ORDER().Result;
                int count = 0;
                data = new List<Customer>();
                foreach (Customer item in datasource)
                {
                    count++;
                    if (count <= 30)
                    {                        
                        data.Add(item);
                    }
                }

                ListCustomer = new ObservableCollection<Customer>(data);
            }
            catch (Exception)
            { 
                ListCustomer = null;
            }
        }

        public async Task<IEnumerable<Customer>> LIST_ORDER()
        {
            try
            {
                string url = Commons.Constants.APP_DOMAIN + "Customer/Get_HoSoKhachHang?type=-1";
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(url).ConfigureAwait(false);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<IEnumerable<Customer>>(await response.Content.ReadAsStringAsync());
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
