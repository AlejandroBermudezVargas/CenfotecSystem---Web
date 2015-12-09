using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class Users
    {
        public Users()
        {
            this.bitacoras = new HashSet<bitacora>();
            this.historial_contrasennas = new HashSet<historial_contrasennas>();
            this.sesions = new HashSet<sesion>();
            this.ventas = new HashSet<venta>();
            this.productos = new HashSet<producto>();
            this.prospectos = new HashSet<prospecto>();
        }
    
        public int id_usuario { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public System.DateTime fecha_nacimiento { get; set; }
        public string telefono { get; set; }
        public string password { get; set; }
        public bool activo { get; set; }
        public int id_rol { get; set; }
    
        public virtual ICollection<bitacora> bitacoras { get; set; }
        public virtual ICollection<historial_contrasennas> historial_contrasennas { get; set; }
        public virtual rol rol { get; set; }
        public virtual ICollection<sesion> sesions { get; set; }
        public virtual ICollection<venta> ventas { get; set; }
        public virtual ICollection<producto> productos { get; set; }
        public virtual ICollection<prospecto> prospectos { get; set; }
    }
}