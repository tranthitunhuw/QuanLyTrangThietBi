//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_TTB2.Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class THIETBI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THIETBI()
        {
            this.PHIEUNHAPs = new HashSet<PHIEUNHAP>();
            this.PHIEUXUATs = new HashSet<PHIEUXUAT>();
        }
    
        public int MaTB { get; set; }
        public string TenTB { get; set; }
        public Nullable<double> Gia { get; set; }
        public string ChucNang { get; set; }
        public string Phong { get; set; }
        public Nullable<int> MaLoaiTB { get; set; }
        public string TinhTrang { get; set; }
        public Nullable<int> MaPB { get; set; }
    
        public virtual LOAITHIETBI LOAITHIETBI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUXUAT> PHIEUXUATs { get; set; }
    }
}
