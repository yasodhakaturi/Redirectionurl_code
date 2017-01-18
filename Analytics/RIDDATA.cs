//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Analytics
{
    using Analytics.Helpers;
    using System;
    using System.Collections.Generic;

    public partial class RIDDATA 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RIDDATA()
        {
            this.SHORTURLDATAs = new HashSet<SHORTURLDATA>();
            this.UIDDATAs = new HashSet<UIDDATA>();
        }
    
        public int PK_Rid { get; set; }
        public string ReferenceNumber { get; set; }
        public string Pwd { get; set; }
        public Nullable<int> FK_ClientId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHORTURLDATA> SHORTURLDATAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UIDDATA> UIDDATAs { get; set; }
        public virtual Client Client { get; set; }
    }
}
