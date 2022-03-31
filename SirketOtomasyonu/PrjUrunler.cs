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

using SirketOtomasyonu.Entity;
namespace SirketOtomasyonu
{
    public partial class PrjUrunler : Form
    {
     
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        public PrjUrunler()
        {
           
            InitializeComponent();
           
        }
    

        void listele()
        {
            gridControl1.DataSource = dbentity.TBL_URUNLER.ToList();
        }
        void temizle()
        {
                TxtAd.Text="";
                cmbMarka.Text = "";
                TxtModel.Text = "";
                MskYil.Text = "";               
                TxtAlis.Text = "";
                TxtSatis.Text = "";
                cmbKategori.Text = "";
                RchDetay.Text = "";
        }     
        void deneme()
        {
       
            cmbKategori.DataSource = dbentity.TBL_KATEGORILER.ToList();
            cmbKategori.DisplayMember = "ADI";
            cmbKategori.ValueMember = "ID";
            var listeMarka = dbentity.TBL_MARKALAR.Select(x => new
            {
                x.ID,
                Marka = x.MARKA
            }).ToList();
            cmbMarka.DataSource = listeMarka;
            cmbMarka.DisplayMember = "MARKA";
            cmbMarka.ValueMember = "ID";
       
        }
 
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            deneme();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            TBL_URUNLER urun = new TBL_URUNLER();
            urun.URUNAD = TxtAd.Text;
            urun.MARKA = cmbMarka.Text;
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
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Ürünü Sistemden Silinecek.Emin Misiniz?", "Ürün Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                TBL_URUNLER urn = dbentity.TBL_URUNLER.Find(int.Parse(TxtId.Text));
                dbentity.TBL_URUNLER.Remove(urn);
                dbentity.SaveChanges();
                MessageBox.Show("Ürün sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            TBL_URUNLER urun = dbentity.TBL_URUNLER.Find(int.Parse(TxtId.Text));
            urun.URUNAD = TxtAd.Text;
            urun.MARKA = cmbMarka.Text;
            urun.MODEL = TxtModel.Text;
            urun.YIL = (MskYil.Text);
            urun.ADET = Convert.ToSByte(NudAdet.Value);
            urun.ALISFIYAT = Convert.ToDecimal(TxtAlis.Text);
            urun.SATISFIYAT = decimal.Parse(TxtSatis.Text);
            urun.KATEGORI = cmbKategori.Text;
            urun.DETAY = RchDetay.Text;
            dbentity.SaveChanges();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void TxtId_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                TBL_URUNLER urn = dbentity.TBL_URUNLER.Find(int.Parse(TxtId.Text));
                if (urn != null)
                {
                    
                    TxtAd.Text = urn.URUNAD;
                    cmbMarka.Text = urn.MARKA;
                    TxtModel.Text = urn.MODEL;
                    MskYil.Text = urn.YIL;
                    NudAdet.Value = Convert.ToSByte(urn.ADET);
                    TxtAlis.Text = (urn.ALISFIYAT).ToString();
                    TxtSatis.Text = (urn.SATISFIYAT).ToString();
                    cmbKategori.Text = urn.KATEGORI;
                    RchDetay.Text = urn.DETAY;
                }
            }
        }

       
    }
}
