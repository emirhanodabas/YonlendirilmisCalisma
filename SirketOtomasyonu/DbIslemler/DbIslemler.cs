using SirketOtomasyonu.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.DbIslemler
{
    abstract class DbIslemler
    {
        // Temel veritabani işlemleri için
        public SqlCommand komut; // sql komutları göndermek için
        public SqlDataAdapter adaptor; // 
        public SqlDataReader okuyucu; // veritabnında veriler okuyor
        public DataTable tablo; // 
        public SqlConnection baglanti; // veritabani bağlantı paramtersi
        private string yolu;

        public DbIslemler()
        {
            // DESKTOP-TSE883Q\SQLEXPRESS DESKTOP-4LSM9E9\SQLEXPRESS
            yolu = @"Server=DESKTOP-4LSM9E9\SQLEXPRESS;Database=Dbo SirketOtomasyon;Trusted_Connection=True;";
        }

        public void Baglan()
        {
            // Veritabanına bağlantıyı sağlıyor
            baglanti = new SqlConnection(yolu);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }


        abstract public void Sil(IVarlik varlik);
        abstract public void Guncelle(IVarlik varlik);
        abstract public void Ekle(IVarlik varlik);
        abstract public DataTable Getir(int id);
        abstract public DataTable Listele(IVarlik varlik);
        abstract public DataTable Listele();

    }
}