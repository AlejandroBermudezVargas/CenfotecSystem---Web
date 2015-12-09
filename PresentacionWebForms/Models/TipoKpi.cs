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
            this.kpis = new HashSet<Kpi>();
        }
    
        public int id_tipo { get; set; }
        public string nombre { get; set; }

        public virtual ICollection<Kpi> kpis { get; set; }
    }
}