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
    
    public partial class benefits
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public benefits()
        {
            this.person_benefits = new HashSet<person_benefits>();
        }
    
        public int benefitsNUM { get; set; }
        public string benefitsNAME { get; set; }
        public string benefitsDESCRIPTION { get; set; }
        public string benefitsKIND { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<person_benefits> person_benefits { get; set; }
    }
}