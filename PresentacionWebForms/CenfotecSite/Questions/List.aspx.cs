﻿using Newtonsoft.Json;
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
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadQuestionsData();
            }

            bindData();
        }

        private void bindData()
        {
            GridQuestionsData.DataSource = Session["QuestionsTable"];
            GridQuestionsData.DataBind();
        }

        private void loadQuestionsData()
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Questions", Method.GET);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;
            List<Question> questions = JsonConvert.DeserializeObject<List<Question>>(json);

            DataTable tableQuestions = new DataTable("questions");
            tableQuestions.Columns.AddRange(new DataColumn[2]{
                new DataColumn("id_pregunta", typeof(string)),
                new DataColumn("pregunta1", typeof(string))
            });


            foreach (var question in questions)
            {
                tableQuestions.Rows.Add(question.id_pregunta, question.pregunta1);
            }


            Session["QuestionsTable"] = tableQuestions;
        }
    }
}