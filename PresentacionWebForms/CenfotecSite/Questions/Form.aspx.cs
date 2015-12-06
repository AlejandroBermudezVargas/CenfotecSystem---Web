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

namespace PresentacionWebForms.CenfotecSite.Questions
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            panelConfirmacion.Style.Add("display", "none");
        }

        protected void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            Question nvaPregunta = new Question(txtPregunta.Text, int.Parse(sltPeso.SelectedValue));
            
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Questions", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(nvaPregunta);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;
            Question pregunta = JsonConvert.DeserializeObject<Question>(json);
            
            DataTable questionsTable = (DataTable)Session["QuestionsTable"];
            txtPregunta.Text = "";
            sltPeso.SelectedIndex = 0;
            panelConfirmacion.Style.Remove("display");
        }
    }
}