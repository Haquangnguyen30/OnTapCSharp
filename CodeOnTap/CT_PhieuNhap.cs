//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeOnTap
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_PhieuNhap
    {
        public int maPN { get; set; }
        public string maSP { get; set; }
        public int makichCo { get; set; }
        public Nullable<double> giaNhap { get; set; }
        public Nullable<int> soLuong { get; set; }
        public Nullable<double> thanhTien { get; set; }
        public Nullable<bool> tinhTrang { get; set; }
    
        public virtual kichCo kichCo { get; set; }
        public virtual phieuNhap phieuNhap { get; set; }
        public virtual sanPham sanPham { get; set; }
    }
}