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
    
    public partial class tblSanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSanpham()
        {
            this.tblBinhluan = new HashSet<tblBinhluan>();
            this.tblChitietdonhang = new HashSet<tblChitietdonhang>();
            this.tblChitietphieunhap = new HashSet<tblChitietphieunhap>();
        }
    
        public int PK_iSanphamID { get; set; }
        public string sTenSP { get; set; }
        public string sHinhanh { get; set; }
        public string sSize { get; set; }
        public string sMota { get; set; }
        public int iSoluong { get; set; }
        public string sDonvi { get; set; }
        public int iDongia { get; set; }
        public int FK_iDanhmucID { get; set; }
        public int FK_iNCCID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBinhluan> tblBinhluan { get; set; }
        public virtual tblDanhmucSP tblDanhmucSP { get; set; }
        public virtual tblNhacungcap tblNhacungcap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChitietdonhang> tblChitietdonhang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChitietphieunhap> tblChitietphieunhap { get; set; }
    }
}
