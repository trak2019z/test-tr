using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP.Models
{
    public class TowaryViewModel
    {
        public string nazwa { get; set; }
        public string kod  { get; set; }
        public long id { get; set; }
        public double netto { get; set; }
        public double vat { get; set; }
        public double brutto { get; set; }
        public string opis { get; set; }
    }
}