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
    
    public partial class vasIzborDana
    {
        public int id { get; set; }
        public int korisnikId { get; set; }
        public int izborId { get; set; }
        public System.DateTime datum { get; set; }
    
        public virtual izbor izbor { get; set; }
        public virtual korisnik korisnik { get; set; }
    }
}
