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
    public partial class PrjPersoneller : Form
    {
        public PrjPersoneller()
        {
            InitializeComponent();
        }
      
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        void personelListele()
        {
            gridControl1.DataSource = dbentity.TBL_PERSONELLER.ToList();
        }       
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            personelListele();
            cmbil.ValueMember = "id";
            cmbil.DisplayMember = "sehir";
            cmbil.DataSource = dbentity.ilcelers.ToList();
          
        }

        //void sehirlistesi()
        //{
        //    cmbil.DataSource = dbentity.TBL_ILLER.ToList();
        //    cmbil.DisplayMember = "SEHIR";
        //    cmbil.ValueMember = "ID";

        //    cmbilce.DataSource = dbentity.TBL_ILCELER.Where(x => x.SEHIR == x.ID).ToList();
        //    cmbilce.DisplayMember = "ILCE";
        //    cmbilce.ValueMember = "SEHIR";
        //}
        private void BtnKaydet_Click(object sender, EventArgs e)
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

    

        private void TxtId_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                TBL_PERSONELLER prs = dbentity.TBL_PERSONELLER.Find(int.Parse(TxtId.Text));
                if (prs != null)
                {
                    TxtAd.Text = prs.AD;
                    TxtSoyad.Text = prs.SOYAD;
                    MskTelefon1.Text= prs.TELEFON;
                    MskTC.Text= prs.TC;
                    TxtMail.Text = prs.MAIL;
                    cmbil.Text = prs.IL;
                    cmbilce.Text = prs.ILCE;
                    TxtMaas.Text=(prs.MAAS).ToString() ;
                    TxtGorev.Text = prs.GOREV ;
                    RchAdres.Text = prs.ADRES;
                }
            }
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbil.SelectedIndex != -1)
            {
                var sehirilceler = from i in dbentity.ilcelers
                                   where i.sehir == Convert.ToInt32(cmbil.SelectedValue)
                                   select i;
                cmbilce.ValueMember = "id";
                cmbilce.DisplayMember = "ilce";
                cmbilce.DataSource = sehirilceler;
            }
        }
    }
}
