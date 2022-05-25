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

        private void Txtid_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txtid.Text))
            {
                TBL_BANKALAR bnk = dbentity.TBL_BANKALAR.Find(int.Parse(Txtid.Text));
                if (bnk != null)
                {
                    TxtBankaAd.Text = bnk.BANKAADI;
                    cmbil.Text = bnk.IL;
                    cmbilce.Text = bnk.ILCE;
                    TxtSube.Text = bnk.SUBE;
                    txtIBAN.Text= bnk.IBAN;
                    txtHesap.Text = bnk.HESAPNO;
                    txtYetki.Text = bnk.YETKILI;
                    MskTelefon.Text = bnk.TELEFON;
                    Msktarih.Text = bnk.TARIH;
                    txtHesaptur.Text = bnk.HESAPTURU;
                }
            }
        }
    }
}
