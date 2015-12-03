using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class Evaluation
    {
        public Evaluation()
        {
            
        }
    
        public int id_evaluacion { get; set; }
        public int usuario_evaluado { get; set; }
        public int porcentaje_desactivacion { get; set; }
        public int curso_evaluado { get; set; }
    
        public virtual List<Question> preguntas { get; set; }
    }
}