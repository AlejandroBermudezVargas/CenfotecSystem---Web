using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PresentacionWebForms;
using System.Configuration;
using Newtonsoft.Json;
using System.Data;
using PresentacionWebForms.Models;

namespace PresentacionWebForms.CenfotecSite.Evaluations
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadEvaluationsData();
            }

            Session["IdTemplateEdit"] = null;
            Session["IdSelectedTemplate"] = null;
            bindData();
        }

        private void bindData()
        {
            GridEvaluationsData.DataSource = Session["EvaluationsTable"];
            GridEvaluationsData.DataBind();
        }

        private void loadEvaluationsData()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Templates", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;
            List<Template> evaluations = JsonConvert.DeserializeObject<List<Template>>(json);

            if (evaluations != null && evaluations.Count > 0)
            {
                DataTable tableEvaluations = new DataTable("templates");
                tableEvaluations.Columns.AddRange(new DataColumn[3]{
                new DataColumn("id_plantilla", typeof(string)),
                new DataColumn("nombre", typeof(string)),
                new DataColumn("descripcion", typeof(string))
            });
                foreach (var evaluation in evaluations)
                {
                    tableEvaluations.Rows.Add(evaluation.id_plantilla, evaluation.nombre, evaluation.descripcion);
                }
                Session["EvaluationsTable"] = tableEvaluations;
                lblMensajeListaVacia.Style.Add("display", "none");
            }
            else
            {
                lblMensajeListaVacia.Style.Remove("display");
            }

        }

        protected void GridEvaluationsData_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Session["IdTemplateEdit"] = GridEvaluationsData.Rows[e.NewEditIndex].Cells[0].Text;
            Response.BufferOutput = true;
            Response.Redirect("../../CenfotecSite/Templates/create.aspx");
        }

        protected void GridEvaluationsData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["IdSelectedTemplate"] = GridEvaluationsData.Rows[GridEvaluationsData.SelectedIndex].Cells[0].Text;
            Response.Redirect("../../CenfotecSite/Evaluations/create.aspx");
        }
    }
}