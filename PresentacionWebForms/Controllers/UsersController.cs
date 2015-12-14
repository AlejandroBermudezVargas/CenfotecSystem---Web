using Newtonsoft.Json;
using PresentacionWebForms.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Controllers
{
    public class UsersController
    {
        public static User Login(string correo, string password)
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Users/Login", Method.POST);
            request.AddParameter("correo", correo);
            request.AddParameter("password", password);
            var response = client.Execute(request) as RestResponse;
            string json = response.Content;
            User user = JsonConvert.DeserializeObject<User>(json);
            if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public static void LogOut(User user)
        {
            RestClient client = new RestClient(ConfigurationManager.AppSettings["endpoint"]);
            RestRequest request = new RestRequest("Users/Login", Method.POST);
            request.AddBody(user);
            var response = client.Execute(request) as RestResponse;

        }

    }
}