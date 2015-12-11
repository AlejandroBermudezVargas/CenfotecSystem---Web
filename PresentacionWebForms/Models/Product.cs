using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class Product
    {
        public int id_producto { get; set; }
        public string codigo_producto { get; set; }
        public string nombre { get; set; }
        public decimal costo { get; set; }
        public string horario { get; set; }
        public int id_tipo_product { get; set; }
    }
}