//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fussball
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tabelle
    {
        public int Platz { get; set; }
        public int VereinID { get; set; }
        public int Punkte { get; set; }
    
        public virtual Team Team { get; set; }
    }
}
