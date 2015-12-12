using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class TipoKpi
    {
        public TipoKpi()
        {
            this.kpis = new HashSet<KPI>();
        }
        public TipoKpi(string nombre)
        {
            this.nombre = nombre;
            this.kpis = new HashSet<KPI>();
        }
    
        public int id_tipo { get; set; }
        public string nombre { get; set; }

        public virtual ICollection<KPI> kpis { get; set; }
    }
}