//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DQH_DATN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblNhacungcap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNhacungcap()
        {
            this.tblSanpham = new HashSet<tblSanpham>();
        }
    
        public int PK_iNCCID { get; set; }
        public string sTenNCC { get; set; }
        public string sDiachi { get; set; }
        public string sSDT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSanpham> tblSanpham { get; set; }
    }
}