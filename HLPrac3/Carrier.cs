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
    
    public partial class Carrier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carrier()
        {
            this.Dispatchers = new HashSet<Dispatcher>();
            this.Drivers = new HashSet<Driver>();
            this.Loads = new HashSet<Load>();
        }
    
        public int id { get; set; }
        public string mc_num { get; set; }
        public string dot_num { get; set; }
        public Nullable<int> billing_id { get; set; }
        public Nullable<int> billing_address_id { get; set; }
        public Nullable<int> dispatch_id { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Contact Contact1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dispatcher> Dispatchers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Driver> Drivers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Load> Loads { get; set; }
    }
}
