﻿using SirketOtomasyonu.Entity;
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
    public partial class PrjGiderler : Form
    {
        public PrjGiderler()
        {
            InitializeComponent();
        }

        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        private void Giderler_Load(object sender, EventArgs e)
        {
            giderListele();
        }
        void giderListele()
        {
            gridControl1.DataSource = dbentity.TBL_GIDERLER.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_GIDERLER gdr = new TBL_GIDERLER();
            gdr.AY = cmbay.Text;
            gdr.YIL = txtSu.Text;
            gdr.ELEKTRIK = Convert.ToDecimal(txtElektrik.Text);
            gdr.SU = Convert.ToDecimal(txtSu.Text);
            gdr.DOGALGAZ = Convert.ToDecimal(txtDgaz.Text);
            gdr.INTERNET = Convert.ToDecimal(txtint.Text);
            gdr.MAASLAR = Convert.ToDecimal(txtMaas.Text);
            gdr.EKSTRA = Convert.ToDecimal(txtekstra.Text);
            gdr.NOTLAR = rchNot.Text;
            dbentity.TBL_GIDERLER.Add(gdr);
            dbentity.SaveChanges();
            giderListele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Gider Sistemden Silinecek.Emin Misiniz?", "Müşteri Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                TBL_GIDERLER gdr = dbentity.TBL_GIDERLER.Find(int.Parse(Txtid.Text));
                dbentity.TBL_GIDERLER.Remove(gdr);
                dbentity.SaveChanges();
                MessageBox.Show("Gider sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                giderListele();
               
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            TBL_GIDERLER gdr = dbentity.TBL_GIDERLER.Find(int.Parse(Txtid.Text));
            gdr.AY = cmbay.Text;
            gdr.YIL = TxtYil.Text;
            gdr.ELEKTRIK = Convert.ToDecimal(txtElektrik.Text);
            gdr.SU = Convert.ToDecimal(txtSu.Text);
            gdr.DOGALGAZ = Convert.ToDecimal(txtDgaz.Text);
            gdr.INTERNET = Convert.ToDecimal(txtint.Text);
            gdr.MAASLAR = Convert.ToDecimal(txtMaas.Text);
            gdr.EKSTRA = Convert.ToDecimal(txtekstra.Text);
            gdr.NOTLAR = rchNot.Text;
            dbentity.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            giderListele();
        }

        private void Txtid_EditValueChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(Txtid.Text))
            {
                TBL_GIDERLER gdr = dbentity.TBL_GIDERLER.Find(int.Parse(Txtid.Text));
                if (gdr != null)
                {
                    cmbay.Text = gdr.AY;
                    TxtYil.Text = gdr.YIL;
                    txtElektrik.Text= (gdr.ELEKTRIK).ToString();
                    txtSu.Text = (gdr.SU).ToString();
                    txtDgaz.Text = (gdr.DOGALGAZ).ToString();
                    txtint.Text = (gdr.INTERNET).ToString();
                    txtMaas.Text=(gdr.MAASLAR).ToString();
                    txtekstra.Text=(gdr.EKSTRA).ToString();                  
                    rchNot.Text=gdr.NOTLAR;
                }
            }
        }
    }
}
