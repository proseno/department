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
    
    public partial class workers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public workers()
        {
            this.delivery = new HashSet<delivery>();
        }
    
        public int workersNUM { get; set; }
        public System.DateTime workersSTART { get; set; }
        public Nullable<System.DateTime> workersEND { get; set; }
        public int personNUM { get; set; }
        public int positionNUM { get; set; }
        public int cechNUM { get; set; }
    
        public virtual cech cech { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<delivery> delivery { get; set; }
        public virtual person person { get; set; }
        public virtual position position { get; set; }
    }
}
