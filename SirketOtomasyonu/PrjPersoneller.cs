using SirketOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu
{
    public partial class PrjPersoneller : Form
    {
        public PrjPersoneller()
        {
            InitializeComponent();
        }
      
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        void personelListele()
        {
            gridControl1.DataSource = dbentity.TBL_PERSONELLER.Select(x=> new {
                x.ID,
                x.AD,
                x.SOYAD,
                x.TELEFON,
                x.TC,
                x.MAIL,
                x.IL,
                x.ILCE,
                x.MAAS,
                x.GOREV,
                x.ADRES
            }).ToList();
        }       
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonDataSet.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilcelerTableAdapter.Fill(this.dbo_SirketOtomasyonDataSet.ilceler);
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonDataSet.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.illerTableAdapter.Fill(this.dbo_SirketOtomasyonDataSet.iller);
            personelListele();
       
          
        }       
        public bool TcDogruMu()
        {
            string kimlikno = MskTC.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numaranızı eksik girdiniz!\nLütfen tekrar deneyin.");
                MskTC.Focus();
                return false;
            }
            int[] sayilar = new int[11];
            for (int i = 0; i < kimlikno.Length; i++)
            {
                sayilar[i] = Int32.Parse(kimlikno[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < kimlikno.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {
                MessageBox.Show("TC Numarası Geçerli");
                return true;
            }
            else
            {
                MessageBox.Show("Girilen Tc Kimlik No yanlıştır!\nLütfen kontrol ediniz.");
                MskTC.Focus();
                return false;
            }
        }
        public bool isEmail()
        {
            string inputEmail = TxtMail.Text;
            if (inputEmail != "")
            {
                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                     @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(inputEmail))
                    return (true);
                else
                    MessageBox.Show("Email adresi bilgileri eksik veya yanlış girdiniz lütfen tekrar deneyiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
            else
            {
                MessageBox.Show("Email adresi boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtMail.Focus();
                return false;
            }
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TcDogruMu() && isEmail())
            {
                TBL_PERSONELLER prs = new TBL_PERSONELLER();
                prs.AD = TxtAd.Text;
                prs.SOYAD = TxtSoyad.Text;
                prs.TELEFON = MskTelefon1.Text;
                prs.TC = MskTC.Text;
                prs.MAIL = TxtMail.Text;
                prs.IL = cmbil.Text;
                prs.ILCE = cmbilce.Text;
                prs.MAAS = Convert.ToDecimal(TxtMaas.Text);
                prs.GOREV = TxtGorev.Text;
                prs.ADRES = RchAdres.Text;
                dbentity.TBL_PERSONELLER.Add(prs);
                dbentity.SaveChanges();
                personelListele();
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Personel Sistemden Silinecek.Emin Misiniz?", "Personel Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                TBL_PERSONELLER prs = dbentity.TBL_PERSONELLER.Find(int.Parse(TxtId.Text));
                dbentity.TBL_PERSONELLER.Remove(prs);
                dbentity.SaveChanges();
                MessageBox.Show("Personel sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personelListele();

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TcDogruMu() && isEmail())
            {
                TBL_PERSONELLER prs = dbentity.TBL_PERSONELLER.Find(int.Parse(TxtId.Text));
                prs.AD = TxtAd.Text;
                prs.SOYAD = TxtSoyad.Text;
                prs.TELEFON = MskTelefon1.Text;
                prs.TC = MskTC.Text;
                prs.MAIL = TxtMail.Text;
                prs.IL = cmbil.Text;
                prs.ILCE = cmbilce.Text;
                prs.MAAS = Convert.ToDecimal(TxtMaas.Text);
                prs.GOREV = TxtGorev.Text;
                prs.ADRES = RchAdres.Text;
                dbentity.SaveChanges();
                personelListele();
            }
            
        }

   
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTelefon1.Text = "";
            MskTC.Text = "";
            TxtMail.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            TxtMaas.Text = "";
            TxtGorev.Text = "";
            RchAdres.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            MskTelefon1.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            MskTC.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            cmbil.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            cmbilce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            TxtMaas.Text = gridView1.GetFocusedRowCellValue("MAAS").ToString();
            TxtGorev.Text = gridView1.GetFocusedRowCellValue("GOREV").ToString();
            RchAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
        }
    }
}
