//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoWpf.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partecipation
    {
        public int Id { get; set; }
        public int IdAthlete { get; set; }
        public Nullable<short> Age { get; set; }
        public string NOC { get; set; }
        public int IdGame { get; set; }
        public int IdEvent { get; set; }
    
        public virtual Athlete Athlete { get; set; }
        public virtual Event Event { get; set; }
        public virtual Game Game { get; set; }
    }
}