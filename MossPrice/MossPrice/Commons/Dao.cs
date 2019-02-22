using MossPrice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace MossPrice.Commons
{
    public class Dao
    {
        //public async Task<IEnumerable<Customer>> LIST_ORDER()
        //{
        //    string url = string.Format(Commons.Constants.APP_DOMAIN + "Customer/Get_HoSoKhachHang?type=-1");
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri(url);
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        //    HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
        //    string content = await response.Content.ReadAsStringAsync();
        //    return JsonConvert.DeserializeObject<IEnumerable<Customer>>(content);            
        //}
        public async Task<ObservableCollection<Customer>> LIST_ORDER()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(string.Format(Commons.Constants.APP_DOMAIN + "Customer/Get_HoSoKhachHang?type=-1"));
                ObservableCollection<Customer> datasource = JsonConvert.DeserializeObject<ObservableCollection<Customer>>(await response.Content.ReadAsStringAsync());
                return datasource;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
