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
    
    public partial class stavkeNarudzbenice
    {
        public int id { get; set; }
        public int lijekId { get; set; }
        public int narudzbenicaId { get; set; }
        public int kolicina { get; set; }
    
        public virtual lijek lijek { get; set; }
        public virtual narudzbenica narudzbenica { get; set; }
    }
}
