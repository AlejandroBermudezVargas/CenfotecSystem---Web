using Newtonsoft.Json;
using PresentacionWebForms.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWebForms.CenfotecSite.Evaluations
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadTeachers();
        }

        private void loadTeachers()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Users/getTeachers", Method.GET);
            var response = client.Execute(request) as RestResponse;
            List<User> teachers = JsonConvert.DeserializeObject<List<User>>(response.Content);

            stlProfesores.DataTextField = "nombre";
            stlProfesores.DataValueField = "id_usuario";
            stlProfesores.DataSource = teachers;
            stlProfesores.DataBind();

        }
    }
}