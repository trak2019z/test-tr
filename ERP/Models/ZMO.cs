//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZMO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZMO()
        {
            this.ZMOPoz = new HashSet<ZMOPoz>();
        }
    
        public long id { get; set; }
        public string kod { get; set; }
        public long idkh { get; set; }
        public double netto { get; set; }
        public Nullable<double> vat { get; set; }
        public Nullable<double> brutto { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public bool czyZrealizowane { get; set; }
    
        public virtual Uzytkownicy Uzytkownicy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZMOPoz> ZMOPoz { get; set; }
    }
}