using Newtonsoft.Json;
using PresentacionWebForms.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWebForms.CenfotecSite.Kpi
{
    public partial class ListarKpiVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadResultsData();
            }
            bindData();
        }

        private void bindData()
        {
            GridKpisData.DataSource = Session["kpisTable"];
            GridKpisData.DataBind();
        }

        private void loadResultsData()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("/Kpis/getKPIVentas", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;
            List<KPI> kpis = JsonConvert.DeserializeObject<List<KPI>>(json);
            if (kpis != null)
            {
                msjListaVacia.Style.Add("display", "none");

                DataTable tableQuestions = new DataTable("kpis");
                tableQuestions.Columns.AddRange(new DataColumn[3]{
                new DataColumn("id_kpi", typeof(int)),
                new DataColumn("descripcion", typeof(string)),
                new DataColumn("indicador", typeof(string))
            });
                foreach (var kpi in kpis)
                {
                    tableQuestions.Rows.Add(kpi.id_kpi, kpi.indicador, kpi.descripcion);
                }
                Session["kpisTable"] = tableQuestions;
            }
            else
            {
                msjListaVacia.Style.Remove("display");
            }
        }

        protected void FireRowCommand(object sender, GridViewCommandEventArgs e)
        {
            string command = e.CommandName;
            string autoId = e.CommandArgument.ToString();
            Session["id_kpi"] = autoId;
            Response.Redirect("ResultadosKpisVentasMontoTotal.aspx?param=autoId");
        }
    }
}