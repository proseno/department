//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Department
{
    using System;
    using System.Collections.Generic;
    
    public partial class person_benefits
    {
        public int person_benefitsNUM { get; set; }
        public Nullable<int> benefitsNUM { get; set; }
        public Nullable<int> personNUM { get; set; }
        public System.DateTime person_benefitsSTART { get; set; }
        public Nullable<System.DateTime> person_benefitsEND { get; set; }
    
        public virtual benefits benefits { get; set; }
        public virtual person person { get; set; }
    }
}