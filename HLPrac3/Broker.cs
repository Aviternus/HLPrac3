//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HLPrac3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Broker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Broker()
        {
            this.Loads = new HashSet<Load>();
        }
    
        public int id { get; set; }
        public Nullable<int> contact_id { get; set; }
        public Nullable<int> account_id { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Contact Contact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Load> Loads { get; set; }
    }
}