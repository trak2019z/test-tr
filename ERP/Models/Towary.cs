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
    
    public partial class Towary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Towary()
        {
            this.DkPzPoz = new HashSet<DkPzPoz>();
            this.DkSpPoz = new HashSet<DkSpPoz>();
            this.DkWzPoz = new HashSet<DkWzPoz>();
            this.DkZkPoz = new HashSet<DkZkPoz>();
            this.MagazynyPoz = new HashSet<MagazynyPoz>();
            this.ZMOPoz = new HashSet<ZMOPoz>();
            this.ZMWPoz = new HashSet<ZMWPoz>();
        }
    
        public long id { get; set; }
        public string nazwa { get; set; }
        public string kod { get; set; }
        public double netto { get; set; }
        public double vat { get; set; }
        public double brutto { get; set; }
        public string opis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DkPzPoz> DkPzPoz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DkSpPoz> DkSpPoz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DkWzPoz> DkWzPoz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DkZkPoz> DkZkPoz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MagazynyPoz> MagazynyPoz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZMOPoz> ZMOPoz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZMWPoz> ZMWPoz { get; set; }
    }
}
