using SirketOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        void listele()
        {
            gridControl1.DataSource = dbentity.TBL_FATURABILGI.ToList();
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
            if (Txtid.Text!="")
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
            if (dr!=null)
            {
                dty.id = dr["FATURABILGI"].ToString();
            }
            dty.Show();
        }
    }
}
