using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class Template
    {
        public Template()
        {
            preguntas = new List<Question>();
        }
    
        public int id_plantilla { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    
        public  List<Question> preguntas { get; set; }
    }
}