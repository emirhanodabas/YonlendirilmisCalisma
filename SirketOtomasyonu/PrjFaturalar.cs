using SirketOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu
{
    public partial class PrjFaturalar : Form
    {
        public PrjFaturalar()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        Sqlbaglanti bgl = new Sqlbaglanti();
        void listele()
        {
            gridControl1.DataSource = dbentity.TBL_FATURABILGI.Select(x=> new {
                x.FATURABILGIID,
                x.SERI,
                x.SIRANO,
                x.TARIH,
                x.SAAT,
                x.VERGIDAIRE,
                x.ALICI,
                x.TESLIMEDEN,
                x.TESLIMALAN

            }).ToList();
            lookUpEdit1.Properties.DataSource = (from y in dbentity.TBL_PERSONELLER
                                                 select new
                                                 {
                                                     y.ID,
                                                    AD= y.AD +" " +y.SOYAD
                                                 }).ToList();
        }
        private void PrjFaturalar_Load(object sender, EventArgs e)
        {
       
            listele();
        }
        
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Txtid.Text=="")
            {
                TBL_FATURABILGI ftr = new TBL_FATURABILGI();
                ftr.SERI = TxtSeri.Text;
                ftr.SIRANO = TxtSiraNo.Text;
                ftr.TARIH = MskTarih.Text;
                ftr.SAAT = MskSaat.Text;
                ftr.VERGIDAIRE = TxtVergi.Text;
                ftr.ALICI = TxtAlici.Text;
                ftr.TESLIMEDEN = TxtTeslimE.Text;
                ftr.TESLIMALAN = TxtTeslimA.Text;
                dbentity.TBL_FATURABILGI.Add(ftr);
                dbentity.SaveChanges();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

            }
            if (Txtid.Text!="" && cmbCariTur.Text=="Firma")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = miktar * fiyat;
                TxtTutar.Text = tutar.ToString();

                TBL_FATURADETAY dty = new TBL_FATURADETAY();
                dty.URUNAD = TxtUrunAd.Text;
                dty.MIKTAR = Convert.ToSByte(TxtMiktar.Text);
                dty.FIYAT = Convert.ToDecimal(TxtFiyat.Text);
                dty.TUTAR = Convert.ToDecimal(TxtTutar.Text);
                dty.FATURAID = int.Parse(TxtFaruraID.Text);
                dbentity.TBL_FATURADETAY.Add(dty);
                dbentity.SaveChanges();
                //hareket tablosu girişi
                TBL_FIRMAHAREKET frmhar = new TBL_FIRMAHAREKET();
                frmhar.URUNID = int.Parse(TxtUrunID.Text);
                frmhar.FIYAT= Convert.ToDecimal(TxtFiyat.Text);
                frmhar.PERSONEL= Convert.ToByte(lookUpEdit1.EditValue.ToString());
                frmhar.FIRMA = Convert.ToByte(TxtFirma.Text);
                frmhar.ADET = Convert.ToByte(TxtMiktar.Text);
                frmhar.TOPLAM= Convert.ToDecimal(TxtTutar.Text);
                frmhar.FATURAID = int.Parse(TxtFaruraID.Text);
                frmhar.TARIH = MskTarih.Text;
                dbentity.TBL_FIRMAHAREKET.Add(frmhar);             
                dbentity.SaveChanges();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }
            if (Txtid.Text != "" && cmbCariTur.Text == "Müşteri")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = miktar * fiyat;
                TxtTutar.Text = tutar.ToString();

                TBL_FATURADETAY dty = new TBL_FATURADETAY();
                dty.URUNAD = TxtUrunAd.Text;
                dty.MIKTAR = Convert.ToSByte(TxtMiktar.Text);
                dty.FIYAT = Convert.ToDecimal(TxtFiyat.Text);
                dty.TUTAR = Convert.ToDecimal(TxtTutar.Text);
                dty.FATURAID = int.Parse(TxtFaruraID.Text);
                dbentity.TBL_FATURADETAY.Add(dty);
                dbentity.SaveChanges();
                //Müşteri tablosu girişi
                TBL_MUSTERIHAREKET mstrhar = new TBL_MUSTERIHAREKET();
                mstrhar.URUNID = int.Parse(TxtUrunID.Text);
                mstrhar.FIYAT = Convert.ToDecimal(TxtFiyat.Text);
                mstrhar.PERSONEL = Convert.ToByte(lookUpEdit1.EditValue.ToString());
                mstrhar.MUSTERI = Convert.ToByte(TxtFirma.Text);
                mstrhar.ADET = Convert.ToByte(TxtMiktar.Text);
                mstrhar.TOPLAM = Convert.ToDecimal(TxtTutar.Text);
                mstrhar.FATURAID = int.Parse(TxtFaruraID.Text);
                mstrhar.TARIH = MskTarih.Text;
                dbentity.TBL_MUSTERIHAREKET.Add(mstrhar);
                dbentity.SaveChanges();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Fatura Sistemden Silinecek.Emin Misiniz?", "Fima Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                TBL_FATURABILGI ftr = dbentity.TBL_FATURABILGI.Find(int.Parse(Txtid.Text));
                dbentity.TBL_FATURABILGI.Remove(ftr);
                dbentity.SaveChanges();
                MessageBox.Show("Fatura sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();

            }
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            TBL_FATURABILGI ftr = dbentity.TBL_FATURABILGI.Find(int.Parse(Txtid.Text));
            ftr.SERI = TxtSeri.Text;
            ftr.SIRANO = TxtSiraNo.Text;
            ftr.TARIH = MskTarih.Text;
            ftr.SAAT = MskSaat.Text;
            ftr.VERGIDAIRE = TxtVergi.Text;
            ftr.ALICI = TxtAlici.Text;
            ftr.TESLIMEDEN = TxtTeslimE.Text;
            ftr.TESLIMALAN = TxtTeslimA.Text;
            dbentity.SaveChanges();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
         
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            PrjFaturaUrunDetay dty = new PrjFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                dty.id = dr["FATURABILGIID"].ToString();
            }
            dty.Show();
            dty.listele();


        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUrunID.Text))
            {
                TBL_URUNLER urn = dbentity.TBL_URUNLER.Find(int.Parse(TxtUrunID.Text));
                if (urn != null)
                {
                    TxtUrunAd.Text = urn.URUNAD;
                    TxtFiyat.Text =(urn.SATISFIYAT).ToString();
                    
                }
            }
        }

        private void BtnbilgiBul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txtid.Text))
            {
                TBL_FATURABILGI blg = dbentity.TBL_FATURABILGI.Find(int.Parse(Txtid.Text));
                if (blg != null)
                {
                    TxtSeri.Text = blg.SERI;
                    TxtSiraNo.Text = blg.SIRANO;
                    MskTarih.Text = blg.TARIH;
                    MskSaat.Text = blg.SAAT;
                    TxtVergi.Text = blg.VERGIDAIRE;
                    TxtAlici.Text = blg.ALICI;
                    TxtTeslimE.Text = blg.TESLIMEDEN;
                    TxtTeslimA.Text = blg.TESLIMALAN;
                    TxtFaruraID.Text = Txtid.Text;
                }
            }
        }

       
    }
}
