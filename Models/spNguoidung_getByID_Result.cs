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
    
    public partial class spNguoidung_getByID_Result
    {
        public int PK_iNguoidungID { get; set; }
        public string sTennguoidung { get; set; }
        public System.DateTime dNgaysinh { get; set; }
        public bool bGioitinh { get; set; }
        public string sDiachi { get; set; }
        public string sSDT { get; set; }
        public string sTendangnhap { get; set; }
        public string sMatkhau { get; set; }
        public int FK_iQuyenID { get; set; }
        public int FK_iTrangthaiID { get; set; }
    }
}
