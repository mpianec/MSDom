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
    
    public partial class narudzbenica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public narudzbenica()
        {
            this.stavkeNarudzbenices = new HashSet<stavkeNarudzbenice>();
        }
    
        public int id { get; set; }
        public int korisnikId { get; set; }
        public System.DateTime datum { get; set; }
    
        public virtual korisnik korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavkeNarudzbenice> stavkeNarudzbenices { get; set; }
    }
}
