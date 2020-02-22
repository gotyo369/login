using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;

namespace login.ViewModels
{
	class usermanager
	{
        const String CuentaOscar = "https://qwekafearrr3.000webhostapp.com/json/oscar.json";
        const String CuentaRaul = "https://qwekafearrr3.000webhostapp.com/json/raul.json";
        const String CuentaMarco = "https://qwekafearrr3.000webhostapp.com/json/marco.json";
        const String passORM = "https://qwekafearrr3.000webhostapp.com/json/pass.json";

        HttpClient client;

        public usermanager()
        {
            client = new HttpClient();
        }
        public async Task<loginViewModel> getCuentaOscar()
        {
            var result = await client.GetStringAsync(CuentaOscar);
            return JsonConvert.DeserializeObject<loginViewModel>(result);
        }
        public async Task<loginViewModel> getCuentaRaul()
        {
            var result = await client.GetStringAsync(CuentaRaul);
            return JsonConvert.DeserializeObject<loginViewModel>(result);
        }
        public async Task<loginViewModel> getCuentaMarco()
        {
            var result = await client.GetStringAsync(CuentaMarco);
            return JsonConvert.DeserializeObject<loginViewModel>(result);
        }
        public async Task<loginViewModel> getpassORM()
        {
            var result = await client.GetStringAsync(passORM);
            return JsonConvert.DeserializeObject<loginViewModel>(result);
        }


        /*public List<D1_BD> Objetos { get; private set; }
        public async Task<List<D1_BD>>getArticulos()
        {
            Objetos= new List<D1_BD>();
            var uri = new Uri(string.Format(usermanager.URL_Articulos, string.Empty));
            try
            {
                var response = await client.GetAsync(URL_Articulos);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Objetos = JsonConvert.DeserializeObject<List<D1_BD>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR tu base no jala {0}", ex.Message);
            }

            return Objetos;
        }
        public List<user> Items { get; private set; }
        public async Task<List<user>> getUsurios()
        {
            Items = new List<user>();
            var uri = new Uri(string.Format(usermanager.URL, string.Empty));
            try
            {
                var response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<user>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR tu base no jala {0}", ex.Message);
            }

            return Items;
        }*/

    }
}

