//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Podaci
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lokacija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lokacija()
        {
            this.Automobils = new HashSet<Automobil>();
        }
    
        public int id_lokacija { get; set; }
        public string lokacija1 { get; set; }
        public string adresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Automobil> Automobils { get; set; }

        public override string ToString()
        {
            return adresa + ", " + lokacija1;
        }
    }
}
