using Newtonsoft.Json;
using PresentacionWebForms.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWebForms.CenfotecSite.Kpi
{
    public partial class CrearKpiVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void generateKpiVentas_Click(object sender, EventArgs e)
        {
            string metaVentasTotalesUsuario = metaVentas.Text;
            string descripcionVentasTotalesUsuario = descripcionVentasTotales.Text;
            string usuario = dropDownSelectUsuario.SelectedValue;
            saveKpiTotalVentas(metaVentasTotalesUsuario, descripcionVentasTotalesUsuario, usuario);
        }

        public void saveKpiTotalVentas(string cantVentas, string descripcion, string usuario)
        {

        }

        private void loadUsuarios()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("kpis", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

            foreach (var product in products)
            {
                DropDownProductos.Items.Add(new ListItem(product.nombre));
            }
        }
    }
}