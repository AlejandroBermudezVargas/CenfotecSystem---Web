using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class Rol
    {
        public int id_rol { get; set; }
        public string nombre { get; set; }
        public Boolean activo { get; set; }
        public List<Permission> permisos { get; set; }
            
    }
}