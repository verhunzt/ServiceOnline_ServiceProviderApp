//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPA_Datahandler
{
    using System;
    using System.Collections.Generic;
    
    public partial class service_category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service_category()
        {
            this.service = new HashSet<service>();
        }
    
        public int Id { get; set; }
        public int asset_id { get; set; }
        public string name { get; set; }
        public System.DateTime createdAt { get; set; }
        public Nullable<System.DateTime> deletedAt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service> service { get; set; }
    }
}
