using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class User
    {
    //    int id_usuario;
    //        Private _cedula As String
    //Private _nombre As String
    //Private _apellido As String
    //Private _correo As String
    //Private _telefono As String
    //Private _password As String
    //Private _id_rol As Integer
    //Private _activo As Boolean
    //Private _fecha_nacimiento As Date
    //Private _rol As RolModel
    //Private _prospectos As List(Of Prospecto)

        public int id_usuario { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string password { get; set; }
        public int id_rol { get; set; }
        public Boolean activo { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public Rol rol { get; set; }
        
        public User()
        {
                
        }

    }
}