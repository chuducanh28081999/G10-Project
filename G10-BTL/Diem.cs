//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace G10_BTL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Diem
    {
        public int MaDiem { get; set; }
        public string MaHS { get; set; }
        public Nullable<int> MaMon { get; set; }
        public Nullable<System.DateTime> TGNhap { get; set; }
        public Nullable<System.DateTime> TGXoa { get; set; }
        public Nullable<int> MaLoaiDiem { get; set; }
        public Nullable<double> Diem1 { get; set; }
        public string DanhGia { get; set; }
        public Nullable<bool> Trangthai { get; set; }
    
        public virtual HocSinh HocSinh { get; set; }
        public virtual LoaiDiem LoaiDiem { get; set; }
        public virtual Mon Mon { get; set; }
    }
}
