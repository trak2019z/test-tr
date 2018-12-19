using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP.Models
{
    public class ZMWPozViewModel
    {
        public long id { get; set; }
        public long idtw { get; set; }
        public float netto { get; set; }
        public float ilosc { get; set; }

        public virtual Towary Towary { get; set; }

    }
}