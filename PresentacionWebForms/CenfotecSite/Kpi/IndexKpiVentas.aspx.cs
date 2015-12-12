using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWebForms.CenfotecSite.Kpi
{
    public partial class IndexKpiVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void generateKpiVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("KpiVentas.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarKpiVentas.aspx");
        }
    }
}