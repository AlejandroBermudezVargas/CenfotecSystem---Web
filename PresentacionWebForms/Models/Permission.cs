using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class Permission
    {

        public int id_permiso { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Permission()
        {


        }
    }
}