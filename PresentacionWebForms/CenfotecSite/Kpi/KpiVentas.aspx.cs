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
            listIndicadores.Add("Ventas Totales por Usuario");
            listIndicadores.Add("Ventas Totales");
            listIndicadores.Add("Montos Totales Por usuario");
            listIndicadores.Add("Montos Totales");
            listIndicadores.Add("Montos por Periodo");

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

            //ResultsData.Controls.Add(new Literal { Text = json });
        }

        private void calculateTotalMontoVentas()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Sales/getTotalMontoVentas", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;

            //ResultsData.Controls.Add(new Literal { Text = json }); to be remove
        }

        protected void generateKpiVentas_Click(object sender, EventArgs e)
        {
            if (DropDownIndicadores.SelectedValue == "Ventas Totales por Usuario")
            {
                Response.Redirect("CrearKpiVentasTotalesUsuario.aspx");
            }
            else if (DropDownIndicadores.SelectedValue == "Monto Total Vendido") 
            {
                calculateTotalMontoVentas();
            }

        }
    }
}