//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogCV.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblExperıence
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Date { get; set; }
        public string Details { get; set; }
        public Nullable<int> ExpID { get; set; }
    
        public virtual tblAbout tblAbout { get; set; }
    }
}
