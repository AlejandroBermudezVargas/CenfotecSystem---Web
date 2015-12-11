using Newtonsoft.Json;
using PresentacionWebForms.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PresentacionWebForms.CenfotecSite.Evaluations
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) if (Session["IdTemplateEdit"] != null) loadSelected();
                else loadQuestions();
        }

        private void loadSelected()
        {
            string id = Session["IdTemplateEdit"].ToString();
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Templates/" + Session["IdTemplateEdit"].ToString(), Method.GET);
            var response = client.Execute(request) as RestResponse;
            Template plantilla = JsonConvert.DeserializeObject<Template>(response.Content);

            if (!response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) panelError.Visible = true;
            else
            {
                txtNombre.Text = plantilla.nombre;
                txtDescripcion.InnerText = plantilla.descripcion;
                request = new RestRequest("Questions", Method.GET);
                response = client.Execute(request) as RestResponse;
                List<Question> questions = JsonConvert.DeserializeObject<List<Question>>(response.Content);

                HtmlGenericControl li;
                foreach (Question question in questions)
                {
                    li = new HtmlGenericControl("li");
                    if (!isTemplateQuestion(plantilla.preguntas, question.id_pregunta))
                        li.Attributes.Add("class", "ui-widget-content list-group-item");
                    else
                        li.Attributes.Add("class", "ui-widget-content list-group-item ui-selectee ui-selected");
                    li.Attributes.Add("id", "" + question.id_pregunta);
                    li.InnerText = question.pregunta1;
                    olQuestions.Controls.Add(li);
                }
            }

        }

        private bool isTemplateQuestion(List<Question> questionsTemplate, int id)
        {
            foreach (Question question in questionsTemplate)
            {
                if (question.id_pregunta == id) return true;
            }
            return false;
        }

        private void loadQuestions()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Questions", Method.GET);
            var response = client.Execute(request) as RestResponse;
            List<Question> questions = JsonConvert.DeserializeObject<List<Question>>(response.Content);

            HtmlGenericControl li;
            if (questions!=null)
            foreach (Question question in questions)
            {
                li = new HtmlGenericControl("li");

                li.Attributes.Add("class", "ui-widget-content list-group-item");
                li.Attributes.Add("id", "" + question.id_pregunta);
                li.InnerText = question.pregunta1;
                li.Attributes.Add("runat", "server");
                olQuestions.Controls.Add(li);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Template template = new Template();
            template.nombre = txtNombre.Text;
            template.descripcion = txtDescripcion.Value;
            char[] splits = { ',', ' ' };
            string[] ids = HiddenFieldPreguntas.Value.Split(splits);
            foreach (string id in ids)
            {
                if (!id.Equals("")) template.preguntas.Add(new Question(Convert.ToInt32(id)));
            }
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            if (Session["IdTemplateEdit"] == null)
            {//POST
                RestRequest request = new RestRequest("Templates", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(template);
                var response = client.Execute(request) as RestResponse;
                if (response.StatusCode.Equals(System.Net.HttpStatusCode.Created)) Response.Redirect("List.aspx");
            }
            else
            {//UPDATE
                RestRequest request = new RestRequest("Templates/" + Session["IdTemplateEdit"].ToString(), Method.PUT);
                template.id_plantilla = Convert.ToInt32(Session["IdTemplateEdit"].ToString());
                request.RequestFormat = DataFormat.Json;
                request.AddBody(template);
                var response = client.Execute(request) as RestResponse;
                if (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent)) Response.Redirect("List.aspx");
            }
        }
    }
}