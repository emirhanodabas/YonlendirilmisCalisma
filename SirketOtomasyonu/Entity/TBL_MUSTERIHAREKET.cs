//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SirketOtomasyonu.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_MUSTERIHAREKET
    {
        public int HAREKETID { get; set; }
        public Nullable<int> URUNID { get; set; }
        public Nullable<byte> ADET { get; set; }
        public Nullable<byte> PERSONEL { get; set; }
        public Nullable<short> MUSTERI { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<decimal> TOPLAM { get; set; }
        public Nullable<int> FATURAID { get; set; }
        public string TARIH { get; set; }
        public string NOTLAR { get; set; }
    
        public virtual TBL_MUSTERILER TBL_MUSTERILER { get; set; }
        public virtual TBL_PERSONELLER TBL_PERSONELLER { get; set; }
        public virtual TBL_URUNLER TBL_URUNLER { get; set; }
    }
}