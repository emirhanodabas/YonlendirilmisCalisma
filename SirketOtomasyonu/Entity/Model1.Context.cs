﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Dbo_SirketOtomasyonEntities : DbContext
    {
        public Dbo_SirketOtomasyonEntities()
            : base("name=Dbo_SirketOtomasyonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBL_FATURABILGI> TBL_FATURABILGI { get; set; }
        public virtual DbSet<TBL_FATURADETAY> TBL_FATURADETAY { get; set; }
        public virtual DbSet<TBL_KATEGORILER> TBL_KATEGORILER { get; set; }
        public virtual DbSet<TBL_MARKALAR> TBL_MARKALAR { get; set; }
        public virtual DbSet<TBL_FIRMALAR> TBL_FIRMALAR { get; set; }
        public virtual DbSet<TBL_GIDERLER> TBL_GIDERLER { get; set; }
        public virtual DbSet<TBL_MUSTERILER> TBL_MUSTERILER { get; set; }
        public virtual DbSet<TBL_NOTLAR> TBL_NOTLAR { get; set; }
        public virtual DbSet<TBL_PERSONELLER> TBL_PERSONELLER { get; set; }
        public virtual DbSet<TBL_STOKLAR> TBL_STOKLAR { get; set; }
        public virtual DbSet<TBL_URUNLER> TBL_URUNLER { get; set; }
        public virtual DbSet<ilceler> ilcelers { get; set; }
        public virtual DbSet<iller> illers { get; set; }
        public virtual DbSet<TBL_BANKALAR> TBL_BANKALAR { get; set; }
        public virtual DbSet<TBL_FIRMAHAREKET> TBL_FIRMAHAREKET { get; set; }
        public virtual DbSet<TBL_MUSTERIHAREKET> TBL_MUSTERIHAREKET { get; set; }
    
        public virtual ObjectResult<BankaBilgileri_Result> BankaBilgileri()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BankaBilgileri_Result>("BankaBilgileri");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<FirmaBilgi_Result> FirmaBilgi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FirmaBilgi_Result>("FirmaBilgi");
        }
    
        public virtual ObjectResult<FirmaHareketler_Result> FirmaHareketler()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FirmaHareketler_Result>("FirmaHareketler");
        }
    
        public virtual ObjectResult<MusteriBilgi_Result> MusteriBilgi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MusteriBilgi_Result>("MusteriBilgi");
        }
    
        public virtual ObjectResult<MusteriHareket_Result> MusteriHareket()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MusteriHareket_Result>("MusteriHareket");
        }
    
        public virtual ObjectResult<PersonelBilgi_Result> PersonelBilgi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PersonelBilgi_Result>("PersonelBilgi");
        }
    
        public virtual ObjectResult<Nullable<decimal>> sp_ToplamTutar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("sp_ToplamTutar");
        }
    }
}
