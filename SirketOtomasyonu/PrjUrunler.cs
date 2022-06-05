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
            gridControl1.DataSource = dbentity.TBL_URUNLER.Select(x=> new {
                x.ID,
                x.URUNAD,
                x.KATEGORI,
                x.MARKA,
                x.MODEL,
                x.YIL,
                x.ADET,               
                x.ALISFIYAT,
                x.SATISFIYAT,
                x.DETAY


            }).ToList();
        }    

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonDataSet1.TBL_MARKALAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_MARKALARTableAdapter.Fill(this.dbo_SirketOtomasyonDataSet1.TBL_MARKALAR);
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonDataSet1.TBL_KATEGORILER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_KATEGORILERTableAdapter.Fill(this.dbo_SirketOtomasyonDataSet1.TBL_KATEGORILER);
            listele();
         
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


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            cmbMarka.Text = "";
            TxtModel.Text = "";
            MskYil.Text = "";            
            TxtAlis.Text = "";
            TxtSatis.Text = "";
            cmbKategori.Text = "";
            RchDetay.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text= gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("URUNAD").ToString();
            cmbMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtModel.Text = gridView1.GetFocusedRowCellValue("MODEL").ToString();
            MskYil.Text = gridView1.GetFocusedRowCellValue("YIL").ToString();
            NudAdet.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("ADET"));
            TxtAlis.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            TxtSatis.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            cmbKategori.Text = gridView1.GetFocusedRowCellValue("KATEGORI").ToString();
            RchDetay.Text = gridView1.GetFocusedRowCellValue("DETAY").ToString();
        }
    }
}
