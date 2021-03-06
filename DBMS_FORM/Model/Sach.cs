//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBMS_FORM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        public Sach()
        {
            this.CungCaps = new HashSet<CungCap>();
            this.DaBans = new HashSet<DaBan>();
            this.Muons = new HashSet<Muon>();
        }
    
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public string NamXB { get; set; }
        public int MaTL { get; set; }
        public Nullable<System.DateTime> NgayXoa { get; set; }
        public Nullable<bool> DaXoa { get; set; }
        public string SoluongCon { get; set; }
    
        public virtual ICollection<CungCap> CungCaps { get; set; }
        public virtual ICollection<DaBan> DaBans { get; set; }
        public virtual ICollection<Muon> Muons { get; set; }
        public virtual TheLoai TheLoai { get; set; }
    }
}
