//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Class_Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class nalaz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nalaz()
        {
            this.lijekoviZaDijagnozu = new HashSet<lijekoviZaDijagnozu>();
        }
    
        public int id { get; set; }
        public string nazivBolesti { get; set; }
        public string dijagnoza { get; set; }
        public int stanarId { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
    
        public virtual korisnik korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lijekoviZaDijagnozu> lijekoviZaDijagnozu { get; set; }
    }
}
