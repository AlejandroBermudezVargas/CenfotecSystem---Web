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
    public partial class KpiVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                loadIndicadoresVentas();
                //generarTipoKpi();
            }
        }

        private void loadIndicadoresVentas() 
        {
            List<string> listIndicadores = new List<string>();
            listIndicadores.Add("Ventas Totales");
            listIndicadores.Add("Montos Totales");
            listIndicadores.Add("Montos por Periodo");

            foreach (var indicador in listIndicadores)
            {
                DropDownIndicadores.Items.Add(new ListItem(indicador));
            }
        }

        public void generarTipoKpi()
        {
            string[] tipoKpi = { "Ventas", "Prospectos", "Vendedores" };
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("tipo_kpi", Method.POST);
            request.RequestFormat = DataFormat.Json;
            for (int i = 0; i < tipoKpi.Length; i++)
            {

                TipoKpi nuevoTipo = new TipoKpi(tipoKpi[i]);
                request.AddObject(nuevoTipo);
                var response = client.Execute(request) as RestResponse;
            }
        }

        protected void generateKpiVentas_Click(object sender, EventArgs e)
        {
            if (DropDownIndicadores.SelectedValue == "Ventas Totales")
            {
                Response.Redirect("CrearKpiVentasTotalesUsuario.aspx");
            }
            else if (DropDownIndicadores.SelectedValue == "Montos Totales") 
            {
                Response.Redirect("CrearKpiVentasMontoTotal.aspx");
            }

        }
    }
}