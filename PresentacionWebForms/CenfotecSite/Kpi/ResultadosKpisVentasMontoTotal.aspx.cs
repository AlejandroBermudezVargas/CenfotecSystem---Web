using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class VerKpisVentasMontoTotal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadData();
                loadMontoPorCumplir();
                KpiResults();
            }
        }

        private void loadData()
        {
            string id_kpi = (string)(Session["id_kpi"]);
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Kpis/" +id_kpi, Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;
            dynamic jsonDe = JsonConvert.DeserializeObject(json);

            string descripcion = jsonDe["descripcion"];
            string indicador = jsonDe["indicador"];
            results_descripcion.Controls.Add(new Literal { Text = descripcion });
            results_meta.Controls.Add(new Literal { Text = indicador });
        }

        private void loadMontoPorCumplir()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Sales/getTotalMontoVentas", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;

            results_monto.Controls.Add(new Literal { Text = json });


        }

        private void KpiResults()
        {
            string textualContent = ((Literal)results_meta.Controls[0]).Text;
            string textualContent2 = ((Literal)results_monto.Controls[0]).Text;

            float data1 = float.Parse(textualContent,
                System.Globalization.CultureInfo.InvariantCulture);
            float data2 = float.Parse(textualContent2,
                System.Globalization.CultureInfo.InvariantCulture);

            if (data2 > data1)
            {
                results_estado.Controls.Add(new Literal { Text = "Cumplido" });
            }
            else
            {
                results_estado.Controls.Add(new Literal { Text = "Sin Cumplir" });
            }

        }
    }
}