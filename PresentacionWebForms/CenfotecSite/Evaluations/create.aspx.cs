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
    public partial class create1 : System.Web.UI.Page
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

        protected void stlProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Products/TeacherCourses/" + stlProfesores.SelectedValue, Method.GET);
            var response = client.Execute(request) as RestResponse;
            User user = JsonConvert.DeserializeObject<User>(response.Content);
            if (user.productos != null)
            {
                sltCurso.DataTextField = "nombre";
                sltCurso.DataValueField = "id_curso";
                sltCurso.DataSource = user.productos;
                sltCurso.DataBind();
            }
        }

        protected void stlProfesores_TextChanged(object sender, EventArgs e)
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Products/TeacherCourses/" + stlProfesores.SelectedValue, Method.GET);
            var response = client.Execute(request) as RestResponse;
            User user = JsonConvert.DeserializeObject<User>(response.Content);
            if (user.productos != null)
            {
                sltCurso.DataTextField = "nombre";
                sltCurso.DataValueField = "id_curso";
                sltCurso.DataSource = user.productos;
                sltCurso.DataBind();
            }
        }

        protected void txtPorcentaje_TextChanged(object sender, EventArgs e)
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Products/TeacherCourses/" + stlProfesores.SelectedValue, Method.GET);
            var response = client.Execute(request) as RestResponse;
            User user = JsonConvert.DeserializeObject<User>(response.Content);
            if (user.productos != null)
            {
                sltCurso.DataTextField = "nombre";
                sltCurso.DataValueField = "id_curso";
                sltCurso.DataSource = user.productos;
                sltCurso.DataBind();
            }
        }
    }
}