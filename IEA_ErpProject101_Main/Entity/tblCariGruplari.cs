//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEA_ErpProject101_Main.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCariGruplari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCariGruplari()
        {
            this.tblCariler = new HashSet<tblCariler>();
            this.tblDepartmanlar = new HashSet<tblDepartmanlar>();
            this.tblStokGirisUst = new HashSet<tblStokGirisUst>();
        }
    
        public int Id { get; set; }
        public string GrupAdi { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCariler> tblCariler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmanlar> tblDepartmanlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStokGirisUst> tblStokGirisUst { get; set; }
    }
}
