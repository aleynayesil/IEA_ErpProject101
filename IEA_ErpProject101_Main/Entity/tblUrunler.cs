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
    
    public partial class tblUrunler
    {
        public int Id { get; set; }
        public string UrunGenelNo { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdı { get; set; }
        public string UrunAciklama { get; set; }
        public string Kutuİcerik { get; set; }
        public Nullable<int> TedarikciFirmaId { get; set; }
        public Nullable<decimal> AlısFiyat { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
        public Nullable<System.DateTime> SaveDate { get; set; }
        public Nullable<int> SaveUserId { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual tblCariler tblCariler { get; set; }
    }
}
