using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SirketOtomasyonu.DbIslemler;
using SirketOtomasyonu.Varliklar;
using SirketOtomasyonu.Entity;
namespace SirketOtomasyonu
{
    public partial class PrjUrunler : Form
    {
        DbUrunler dbUrunler = new DbUrunler();
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        
        public PrjUrunler()
        {
            InitializeComponent();
            

        }
        Sqlbaglanti bgl = new Sqlbaglanti();

        void listele()
        {
            gridControl1.DataSource = dbUrunler.Listele();
        }
        void markaListesi()
        {
            
            SqlCommand komut = new SqlCommand("Select KATEGORI from TBL_MARKALAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbKategori.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            markaListesi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            TBL_URUNLER urun = new TBL_URUNLER();
            urun.URUNAD = TxtAd.Text;
            urun.MARKA = TxtMarka.Text;
            urun.MODEL = TxtModel.Text;
            urun.YIL = (MskYil.Text);
            urun.ADET = Convert.ToSByte(NudAdet.Value);
            urun.ALISFIYAT = Convert.ToDecimal(TxtAlis.Text);
            urun.SATISFIYAT = decimal.Parse(TxtSatis.Text);
            urun.KATEGORI = cmbKategori.Text;
            urun.DETAY = RchDetay.Text;
            dbentity.TBL_URUNLER.Add(urun);
            dbentity.SaveChanges();            
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.Id = int.Parse(TxtId.Text);
            dbUrunler.Sil(urun);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,KATEGORI=@p8,DETAY=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@p8", cmbKategori.Text);
            komut.Parameters.AddWithValue("@p9", RchDetay.Text);
            komut.Parameters.AddWithValue("@p10", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
      

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtMarka.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select MARKA from TBL_MARKALAR where KATEGORI=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbKategori.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtMarka.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["URUNAD"].ToString();
            TxtMarka.Text = dr["MARKA"].ToString();
            TxtModel.Text = dr["MODEL"].ToString();
            MskYil.Text = dr["YIL"].ToString();
            NudAdet.Value = decimal.Parse(dr["ADET"].ToString());
            TxtAlis.Text = dr["ALISFIYAT"].ToString();
            TxtSatis.Text = dr["SATISFIYAT"].ToString();
            cmbKategori.Text = dr["KATEGORI"].ToString();
            RchDetay.Text = dr["DETAY"].ToString();
        }
    }
}
