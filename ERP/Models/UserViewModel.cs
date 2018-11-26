using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP.Models
{
    public class UserViewModel
    {
        public string  nazwa { get; set; }
        public string haslo { get; set; }
        public long id { get; set; }
        public string rola { get; set; }
        public string ulica { get; set; }
        public string kodpocz { get; set; }
        public string miejscowosc { get; set; }
        public string nip { get; set; }
    }
}