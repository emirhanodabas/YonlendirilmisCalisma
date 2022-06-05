﻿using DevExpress.XtraGrid.Views.Grid;
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
    public partial class PrjFirmalar : Form
    {
        public PrjFirmalar()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonCity.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilcelerTableAdapter.Fill(this.dbo_SirketOtomasyonCity.ilceler);
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonCity.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.illerTableAdapter.Fill(this.dbo_SirketOtomasyonCity.iller);

            FirmaListele();
       
        }
        void FirmaListele()
        {
            gridControl1.DataSource = dbentity.TBL_FIRMALAR.ToList();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtYetkili.Text = gridView1.GetFocusedRowCellValue("YETKILIADSOYAD").ToString();
            TxtYetkiliGorev.Text = gridView1.GetFocusedRowCellValue("YETKILISTATU").ToString();
            MskYetkiliTC.Text = gridView1.GetFocusedRowCellValue("YETKILITC").ToString();
            TxtSektor.Text = gridView1.GetFocusedRowCellValue("SEKTOR").ToString();
            MskTelefon1.Text = gridView1.GetFocusedRowCellValue("TELEFON1").ToString();
            MskTelefon2.Text = gridView1.GetFocusedRowCellValue("TELEFON2").ToString();
            MskTelefon3.Text = gridView1.GetFocusedRowCellValue("TELEFON3").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            MskFax.Text = gridView1.GetFocusedRowCellValue("FAX").ToString();
            cmbil.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            cmbilce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            TxtVergi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
            RchAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();

        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            TBL_FIRMALAR frm = new TBL_FIRMALAR();
            frm.AD = TxtAd.Text;
            frm.YETKILIADSOYAD = TxtYetkili.Text;
            frm.YETKILISTATU = TxtYetkiliGorev.Text;
            frm.YETKILITC = MskYetkiliTC.Text;
            frm.SEKTOR = TxtSektor.Text;
            frm.TELEFON1 = MskTelefon1.Text;
            frm.TELEFON2 = MskTelefon2.Text;
            frm.TELEFON3 = MskTelefon3.Text;
            frm.MAIL = TxtMail.Text;
            frm.FAX = MskFax.Text;
            frm.IL = cmbil.Text;
            frm.ILCE = cmbilce.Text;
            frm.VERGIDAIRE = TxtVergi.Text;
            frm.ADRES = RchAdres.Text;
            dbentity.TBL_FIRMALAR.Add(frm);
            dbentity.SaveChanges();
            FirmaListele();
          
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Firma Sistemden Silinecek.Emin Misiniz?", "Fima Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                TBL_FIRMALAR frm = dbentity.TBL_FIRMALAR.Find(int.Parse(TxtId.Text));
                dbentity.TBL_FIRMALAR.Remove(frm);
                dbentity.SaveChanges();
                MessageBox.Show("Firma sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirmaListele();

            }
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            TBL_FIRMALAR frm = dbentity.TBL_FIRMALAR.Find(int.Parse(TxtId.Text));
            frm.AD = TxtAd.Text;
            frm.YETKILIADSOYAD = TxtYetkili.Text;
            frm.YETKILISTATU = TxtYetkiliGorev.Text;
            frm.YETKILITC = MskYetkiliTC.Text;
            frm.SEKTOR = TxtSektor.Text;
            frm.TELEFON1 = MskTelefon1.Text;
            frm.TELEFON2 = MskTelefon2.Text;
            frm.TELEFON3 = MskTelefon3.Text;
            frm.MAIL = TxtMail.Text;
            frm.FAX = MskFax.Text;
            frm.IL = cmbil.Text;
            frm.ILCE = cmbilce.Text;
            frm.VERGIDAIRE = TxtVergi.Text;
            frm.ADRES = RchAdres.Text;
            dbentity.SaveChanges();
            MessageBox.Show("Firma Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FirmaListele();
        }
        
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtYetkiliGorev.Text = "";
            TxtYetkili.Text = "";
            MskYetkiliTC.Text = "";
            TxtSektor.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
            MskTelefon3.Text = "";
            TxtMail.Text = "";
            MskFax.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            TxtVergi.Text = "";
            RchAdres.Text = "";
        }

        
    }
}
