using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirketOtomasyonu.Varliklar;

namespace SirketOtomasyonu.DbIslemler
{
    class DbUrunler : DbIslemler
    {
        public override void Ekle(IVarlik varlik)
        {
            Urunler urun = (Urunler)varlik;
            Baglan();
            string sorgu = "insert into TBL_URUNLER values (@URUNAD,@MARKA,@MODEL,@YIL,@ADET,@ALISFIYAT,@SATISFIYAT,@KATEGORI,@DETAY) ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@URUNAD", urun.Urunadi);
            komut.Parameters.AddWithValue("@MARKA", urun.Marka);
            komut.Parameters.AddWithValue("@MODEL", urun.Model);
            komut.Parameters.AddWithValue("@YIL", urun.Yil);
            komut.Parameters.AddWithValue("@ADET", urun.Adet);
            komut.Parameters.AddWithValue("@ALISFIYAT", urun.Alisfiyat);
            komut.Parameters.AddWithValue("@SATISFIYAT", urun.Satisfiyat);
            komut.Parameters.AddWithValue("@KATEGORI", urun.Kategori);
            komut.Parameters.AddWithValue("@DETAY", urun.Detay);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();

            
           
            MessageBox.Show("Ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public override DataTable Getir(int id)
        {
            Baglan();
            string sorgu = "select *from TBL_URUNLER where ID=" + id;
            tablo = new DataTable();
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override void Guncelle(IVarlik varlik)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele(IVarlik varlik)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele()
        {
            Baglan();
            adaptor = new SqlDataAdapter("Select*from TBL_URUNLER", baglanti);
            tablo = new DataTable();
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override void Sil(IVarlik varlik)
        {
            Urunler urun = (Urunler)varlik;
            Baglan();
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Ürünü Sistemden Silinecek.Emin Misiniz?", "Ürün Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {               
                komut = new SqlCommand("delete TBL_URUNLER where ID="+urun.Id,baglanti);                
                komut.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Dispose();
                MessageBox.Show("Ürün sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }
        }

    }
}
