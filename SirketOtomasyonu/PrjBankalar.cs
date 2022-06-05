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
    public partial class PrjBankalar : Form
    {
        public PrjBankalar()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();

        private void PrjBankalar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonDataSet.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilcelerTableAdapter.Fill(this.dbo_SirketOtomasyonDataSet.ilceler);
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonDataSet.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.illerTableAdapter.Fill(this.dbo_SirketOtomasyonDataSet.iller);
            bankaListele();
        }
        void bankaListele()
        {
            gridControl1.DataSource = dbentity.TBL_BANKALAR.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_BANKALAR bnk = new TBL_BANKALAR();
            bnk.BANKAADI = TxtBankaAd.Text;
            bnk.IL = cmbil.Text;
            bnk.ILCE = cmbilce.Text;
            bnk.SUBE = TxtSube.Text;
            bnk.IBAN = txtIBAN.Text;
            bnk.HESAPNO = txtHesap.Text;
            bnk.YETKILI = txtYetki.Text;
            bnk.TELEFON = MskTelefon.Text;
            bnk.TARIH = Msktarih.Text;
            bnk.HESAPTURU = txtHesaptur.Text;
            dbentity.TBL_BANKALAR.Add(bnk);
            dbentity.SaveChanges();
            bankaListele();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Banka Sistemden Silinecek.Emin Misiniz?", "Müşteri Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                TBL_BANKALAR bnk = dbentity.TBL_BANKALAR.Find(int.Parse(Txtid.Text));
                dbentity.TBL_BANKALAR.Remove(bnk);
                dbentity.SaveChanges();
                MessageBox.Show("Banka sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bankaListele();

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            TBL_BANKALAR bnk = dbentity.TBL_BANKALAR.Find(int.Parse(Txtid.Text));
            bnk.BANKAADI = TxtBankaAd.Text;
            bnk.IL = cmbil.Text;
            bnk.ILCE = cmbilce.Text;
            bnk.SUBE = TxtSube.Text;
            bnk.IBAN = txtIBAN.Text;
            bnk.HESAPNO = txtHesap.Text;
            bnk.YETKILI = txtYetki.Text;
            bnk.TELEFON = MskTelefon.Text;
            bnk.TARIH = Msktarih.Text;
            bnk.HESAPTURU = txtHesaptur.Text;
            dbentity.SaveChanges();
            MessageBox.Show("Banka Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bankaListele();
        }

       

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Txtid.Text= gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtBankaAd.Text = gridView1.GetFocusedRowCellValue("BANKAADI").ToString();
            cmbil.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            cmbilce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            TxtSube.Text = gridView1.GetFocusedRowCellValue("SUBE").ToString();
            txtIBAN.Text = gridView1.GetFocusedRowCellValue("IBAN").ToString();
            txtHesap.Text = gridView1.GetFocusedRowCellValue("HESAPNO").ToString();
            txtYetki.Text = gridView1.GetFocusedRowCellValue("YETKILI").ToString();
            MskTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            Msktarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            txtHesaptur.Text = gridView1.GetFocusedRowCellValue("HESAPTURU").ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Txtid.Text = "";
            TxtBankaAd.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            TxtSube.Text = "";
            txtIBAN.Text = "";
            txtHesap.Text = "";
            txtYetki.Text = "";
            MskTelefon.Text = "";
            Msktarih.Text = "";
            txtHesaptur.Text = "";
        }
    }
}
