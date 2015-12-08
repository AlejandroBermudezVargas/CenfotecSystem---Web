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
            loadQuestions();

        }

        private void loadQuestions()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Questions", Method.GET);
            var response = client.Execute(request) as RestResponse;
            List<Question> questions = JsonConvert.DeserializeObject<List<Question>>(response.Content);

            HtmlGenericControl li;
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


        // utility method to recursively find controls matching a predicate
        IEnumerable<Control> FindRecursive(Control c, Func<Control, bool> predicate)
        {
            if (predicate(c))
                yield return c;

            foreach (var child in c.Controls)
            {
                if (predicate((Control)child))
                {
                    yield return (Control)child;
                }
            }

            foreach (var child in c.Controls)
                foreach (var match in FindRecursive((Control)child, predicate))
                    yield return match;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Template template = new Template();
            template.nombre = txtNombre.Text;
            template.descripcion = txtDescripcion.Value;
            char[] splits = {',',' '};
            string[] ids= HiddenFieldPreguntas.Value.Split(splits);
            foreach (string id in ids)
            {
                if (!id.Equals("")) template.preguntas.Add(new Question(Convert.ToInt32(id)));
            }
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Templates", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(template);
            var response = client.Execute(request) as RestResponse;
        }
    }
}