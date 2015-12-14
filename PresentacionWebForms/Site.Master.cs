using PresentacionWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWebForms
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Init()
        {
            this.LoadMenu();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["User"] == null)
                    Response.Redirect("Login.aspx");
                else
                {
                    Response.ClearHeaders();
                    Response.AddHeader("Cache-Control", "no-cache, no-store, max-age=0, must-revalidate");
                    Response.AddHeader("Pragma", "no-cache");
                }
            }
            User userObj = (User)Session["User"];
            UserLoged.InnerHtml = "Bienvenido " + userObj.nombre;
            datosUser.InnerHtml = userObj.nombre + " " + userObj.apellido + " - " + userObj.rol.nombre;
        }

        protected void cerrarSesion(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("CenfotecSite/Login/Login.aspx");

        }

        protected void LoadMenu()
        {
            User user = (User)Session["User"];
            foreach (Permission permiso in user.rol.permisos)
            {
                if (permiso != null)
                {
                    switch (permiso.nombre)
                    {
                        case "kpis":
                            botonMenuKpis.Visible = true;
                            break;
                        case "reportes":
                            botonMenuReportes.Visible = true;
                            break;
                        case "evaluaciones":
                            botonMenuEvaluaciones.Visible = true;
                            break;
                        case "preguntas":
                            botonMenuEvaluaciones.Visible = true;
                            break;
                    }
                }

            }

        }
    }
}