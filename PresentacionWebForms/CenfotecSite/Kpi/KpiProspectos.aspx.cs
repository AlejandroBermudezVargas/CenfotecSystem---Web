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
    public partial class KpiProspectos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadIndicadosProspectos();
            }
        }

        private void loadIndicadosProspectos() 
        {
            List<string> listIndicadores = new List<string>();
            listIndicadores.Add("Total Prospectos");
            listIndicadores.Add("Total Prospectos Cliente");

            foreach (var indicador in listIndicadores)
            {
                DropDownIndicadores.Items.Add(new ListItem(indicador));
            }
        }

        private  void loadResultsTotalProspectos() 
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Sales/getTotalProspectos", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;

            ResultsData.Controls.Add(new Literal { Text = json});
        }

        private void loadResultsTotalProspectosCliente()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Sales/getTotalProspectosClientes", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;

            ResultsData.Controls.Add(new Literal { Text = json });
        }

        protected void generateKpiProspectus_Click(object sender, EventArgs e)
        {
            if (DropDownIndicadores.SelectedValue == "Total Prospectos")
            {
                loadResultsTotalProspectos();
            }
            else if (DropDownIndicadores.SelectedValue == "Total Prospectos Cliente") 
            {
                loadResultsTotalProspectosCliente();
            }
        }
    }
}