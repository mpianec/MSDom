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
    
    public partial class praonica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public praonica()
        {
            this.rezervacijaPraonice = new HashSet<rezervacijaPraonice>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public byte zauzeto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rezervacijaPraonice> rezervacijaPraonice { get; set; }
    }
}
