using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class Question
    {
        public Question(string ppregunta, int ppeso)
        {
            this.pregunta1 = ppregunta;
            this.peso = ppeso;
        }

        public Question(int pid)
        {
            id_pregunta = pid;
        }

        public int id_pregunta { get; set; }
        public string pregunta1 { get; set; }
        public int peso { get; set; }
    }
}