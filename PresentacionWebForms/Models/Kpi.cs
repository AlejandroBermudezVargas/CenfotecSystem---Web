using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWebForms.Models
{
    public class Kpi
    {
        public int id_kpi { get; set; }
        public int id_tipo { get; set; }
        public string descripcion { get; set; }
        public string indicador { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_final { get; set; }

        public virtual TipoKpi tipo_kpi { get; set; }
    }
}