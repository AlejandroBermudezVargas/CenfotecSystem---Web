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
    public partial class KpiVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                loadIndicadoresVentas();
            }
        }

        private void loadIndicadoresVentas() 
        {
            List<string> listIndicadores = new List<string>();
            listIndicadores.Add("Total de Ventas");
            listIndicadores.Add("Monto Total Vendido");
            listIndicadores.Add("Producto de Mayor Venta");
            listIndicadores.Add("Mes de Mayor Venta");

            foreach (var indicador in listIndicadores)
            {
                DropDownIndicadores.Items.Add(new ListItem(indicador));
            }
        }

        private void calculateTotalVentas()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("/Sales/getTotalVentas", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;

            ResultsData.Controls.Add(new Literal { Text = json });
        }

        private void calculateTotalMontoVentas()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Sales/getTotalMontoVentas", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;

            ResultsData.Controls.Add(new Literal { Text = json });
        }

        protected void generateKpiVentas_Click(object sender, EventArgs e)
        {
            if (DropDownIndicadores.SelectedValue == "Total de Ventas")
            {
                calculateTotalVentas();
            }
            else if (DropDownIndicadores.SelectedValue == "Monto Total Vendido") 
            {
                calculateTotalMontoVentas();
            }

        }
    }
}