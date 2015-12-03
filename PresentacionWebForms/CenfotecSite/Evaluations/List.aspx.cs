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
            
            bindData();
        }

        private void bindData()
        {
            GridEvaluationsData.DataSource = Session["EvaluationsTable"];
            GridEvaluationsData.DataBind();
        }

        private void loadEvaluationsData(){
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Evaluations", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;
            List<Evaluation> evaluations = JsonConvert.DeserializeObject<List<Evaluation>>(json);

            DataTable tableEvaluations = new DataTable("evaluations");
            tableEvaluations.Columns.AddRange(new DataColumn[2]{
                new DataColumn("id_evaluacion", typeof(string)),
                new DataColumn("porcentaje_desactivacion", typeof(string))
            });


            foreach (var evaluation in evaluations)
            {
                tableEvaluations.Rows.Add(evaluation.id_evaluacion, evaluation.porcentaje_desactivacion);
            }
            

            Session["EvaluationsTable"] = tableEvaluations;
        }
    }
}