﻿using PresentacionWebForms.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWebForms.CenfotecSite.Kpi
{
    public partial class CrearkpiVentasTotales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void generateKpiVentas_Click(object sender, EventArgs e)
        {
            string montoMeta = metaTotalVentas.Text;
            string descipcion = descripcionTotalVentas.Text;
            KPI nuevoKpi = new KPI(descipcion, montoMeta);
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Kpis", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddObject(nuevoKpi);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;

            if (response.ResponseStatus != ResponseStatus.Error)
            {
                pnlMensajeExito.Visible = true;
            }
            else
            {
                pnlMensajeError.Visible = true;
            }

        }


    }
}