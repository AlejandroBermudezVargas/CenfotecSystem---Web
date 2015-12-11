using Newtonsoft.Json;
using PresentacionWebForms.Controllers;
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


namespace PresentacionWebForms.CenfotecSite.Login

{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Focus();
            mensajeError.Style.Add("display", "none");
            mensajeError2.Style.Add("display", "none");
        }

        protected void Login(object sender, EventArgs e)
        {
            User user = UsersController.Login(userName.Text, password.Text);

            if (user != null)
            {
                Session["User"] = user;
                if (user.activo)
                {
                    Response.Redirect("/Default.aspx", true);
                }
                else
                {
                    mensajeError2.Style.Remove("display");
                }
            }
            else
            {
                mensajeError.Style.Remove("display");
            }

        }

    }
}
  