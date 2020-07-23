//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SILS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.HoldingLists = new HashSet<HoldingList>();
        }
    
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string PublicationYear { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public string KDCId { get; set; }
        public string Picture { get; set; }
    
        public virtual Code Code { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoldingList> HoldingLists { get; set; }
    }
}
