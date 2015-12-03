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
            GridView1.DataSource = Session["EvaluationsTable"];
            GridView1.DataBind();
        }

        private void loadEvaluationsData(){
            //RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            //RestRequest request = new RestRequest("ducks", Method.GET);
            //var response = client.Execute(request) as RestResponse;
            //string json = response.Content;
            //List<Duck> duckList = JsonConvert.DeserializeObject<List<Duck>>(json);

            DataTable tableEvaluations = new DataTable("evaluations");
            tableEvaluations.Columns.AddRange(new DataColumn[4]{
                new DataColumn("name", typeof(string)),
                new DataColumn("evaluado", typeof(string)),
                new DataColumn("estado", typeof(string)),
                new DataColumn("contador", typeof(string)),
            });

            tableEvaluations.Rows.Add("Eval 1", "Jose Romero", "Activa", "16/30");
            tableEvaluations.Rows.Add("Eval 1", "Alvaro Cordero", "Activa", "16/30");
            tableEvaluations.Rows.Add("Eval 1", "Kemly Cordoba", "Activa", "16/30");
            tableEvaluations.Rows.Add("Eval 1", "Alvaro Ospina", "Activa", "16/30");

            Session["EvaluationsTable"] = tableEvaluations;
        }
    }
}