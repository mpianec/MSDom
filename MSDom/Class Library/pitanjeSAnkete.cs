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
    
    public partial class pitanjeSAnkete
    {
        public int id { get; set; }
        public int pitanjeId { get; set; }
        public int anketaId { get; set; }
    
        public virtual anketa anketa { get; set; }
        public virtual pitanje pitanje { get; set; }
    }
}
