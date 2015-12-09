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
            if (!IsPostBack)
            {
                if (Session["IdQuestionEdit"] != null)
                {
                    cargarForm();
                }
            }
                
            panelConfirmacion.Style.Add("display", "none");
        }

        protected void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            string nvo = txtPregunta.Text;
            Question nvaPregunta = new Question(txtPregunta.Text, int.Parse(sltPeso.SelectedValue));
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request;

            if (Session["IdQuestionEdit"] == null)
            {
                request = new RestRequest("Questions", Method.POST);
            }
            else
            {
                string idPregunta = Session["IdQuestionEdit"].ToString();
                request = new RestRequest("Questions/"+idPregunta, Method.PUT);
                nvaPregunta.id_pregunta = int.Parse(idPregunta);
            }

            request.RequestFormat = DataFormat.Json;
            request.AddBody(nvaPregunta);
            var response = client.Execute(request) as RestResponse;

            if (response.StatusCode.Equals(System.Net.HttpStatusCode.Created))
            {
                panelConfirmacion.Style.Remove("display");
                txtPregunta.Text = "";
                sltPeso.SelectedIndex = 0;
            }
            else if(response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent))
            {
                Session["IdQuestionEdit"] = null;
                panelConfirmacion.Style.Remove("display");
            }
        }

        private void cargarForm()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Questions", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("id", Session["IdQuestionEdit"]);
            var response = client.Execute(request) as RestResponse;
            Question pregunta = JsonConvert.DeserializeObject<Question>(response.Content);
            txtPregunta.Text = pregunta.pregunta1;
            sltPeso.SelectedValue = pregunta.peso.ToString();
        }
    }
}