using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using System.Configuration;
using System.Data;
using Newtonsoft.Json;
using PresentacionWebForms.Models;

namespace PresentacionWebForms.CenfotecSite.Kpi
{
    public partial class GenerarKPIProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadProducts();
                loadInicadores();
            }

        }

        private void loadProducts()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Products", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

            foreach (var product in products)
            {
                DropDownProductos.Items.Add(new ListItem(product.nombre));
            }

            
        }

        private void loadInicadores()
        {
            List<string> listIndicadores = new List<string>();
            listIndicadores.Add("Mas vendido");
            listIndicadores.Add("Menos vendido");
            
            foreach (var indicador in listIndicadores)
            {
               DropDownIndicadores.Items.Add(new ListItem(indicador));
            }


        }
    }
}