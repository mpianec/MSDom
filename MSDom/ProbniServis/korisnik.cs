//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProbniServis
{
    using System;
    using System.Collections.Generic;
    
    public partial class korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public korisnik()
        {
            this.rezervacijaPraonices = new HashSet<rezervacijaPraonice>();
        }
    
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public Nullable<int> sobaId { get; set; }
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        public int ulogaId { get; set; }
        public string email { get; set; }
        public Nullable<System.TimeSpan> predbilježbaOd { get; set; }
        public Nullable<System.TimeSpan> predbilježbaDo { get; set; }
    
        public virtual uloga uloga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rezervacijaPraonice> rezervacijaPraonices { get; set; }
    }
}
