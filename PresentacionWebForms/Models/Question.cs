using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class Question
    {
        public Question()
        {
        }
    
        public int id_pregunta { get; set; }
        public int id_respuesta { get; set; }
        public Answer respuesta { get; set; }
    }
}