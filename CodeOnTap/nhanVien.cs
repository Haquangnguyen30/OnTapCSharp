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
    
    public partial class nhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhanVien()
        {
            this.hoaDons = new HashSet<hoaDon>();
            this.phieuNhaps = new HashSet<phieuNhap>();
        }
    
        public string maNV { get; set; }
        public string tenNV { get; set; }
        public string gioiTinh { get; set; }
        public string sdt { get; set; }
        public string diaChi { get; set; }
        public string chucVu { get; set; }
        public Nullable<System.DateTime> ngaySinh { get; set; }
        public Nullable<bool> tinhTrang { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoaDon> hoaDons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phieuNhap> phieuNhaps { get; set; }
    }
}
