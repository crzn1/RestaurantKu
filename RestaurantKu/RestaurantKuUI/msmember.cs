//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantKuUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class msmember
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public msmember()
        {
            this.headorders = new HashSet<headorder>();
        }
    
        public int memberid { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string handphone { get; set; }
        public System.DateTime joindate { get; set; }
        public string password { get; set; }
        public string CCNumber { get; set; }
        public string BankName { get; set; }
        public string AccNumber { get; set; }
        public string Address { get; set; }
        public string Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<headorder> headorders { get; set; }
    }
}
