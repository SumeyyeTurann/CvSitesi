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
    
    public partial class tblEducatıon
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Subtıtle { get; set; }
        public string Department { get; set; }
        public Nullable<decimal> GPA { get; set; }
        public Nullable<int> EduID { get; set; }
    
        public virtual tblAbout tblAbout { get; set; }
    }
}
