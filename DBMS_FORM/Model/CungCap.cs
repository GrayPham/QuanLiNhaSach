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
    
    public partial class CungCap
    {
        public int MaSach { get; set; }
        public int MNCC { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<int> DonGiaNhap { get; set; }
        public Nullable<int> maNQL { get; set; }
        public System.DateTime NgayNhap { get; set; }
    
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual NV NV { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
