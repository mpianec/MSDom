//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSDom
{
    using System;
    using System.Collections.Generic;
    
    public partial class lijek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lijek()
        {
            this.korisnikLijekas = new HashSet<korisnikLijeka>();
            this.lijekoviZaDijagnozus = new HashSet<lijekoviZaDijagnozu>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public int kolicina { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<korisnikLijeka> korisnikLijekas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lijekoviZaDijagnozu> lijekoviZaDijagnozus { get; set; }
    }
}