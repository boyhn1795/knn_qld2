//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDiem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Diem
    {
        public string HocsinhID { get; set; }
        public decimal Diemtk { get; set; }
        public string Hanhkiem { get; set; }
    
        public virtual Hocsinh Hocsinh { get; set; }
    }
}
