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
    public partial class PrjMusteriler :Form
    {
        public PrjMusteriler()
        {
            InitializeComponent();
            listele();
            
            
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonDataSet.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilcelerTableAdapter.Fill(this.dbo_SirketOtomasyonDataSet.ilceler);
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonDataSet.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.illerTableAdapter.Fill(this.dbo_SirketOtomasyonDataSet.iller);


        }
        void listele()
        {
            gridControl1.DataSource = dbentity.TBL_MUSTERILER.ToList();
        }
      
        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            TBL_MUSTERILER mstr = new TBL_MUSTERILER();
            mstr.AD = TxtAd.Text;
            mstr.SOYAD = TxtSoyad.Text;
            mstr.TELEFON = MskTelefon1.Text;
            mstr.TELEFON2 = MskTelefon2.Text;
            //mstr.TC = MskTC.Text;
            mstr.TC = TxtTC.Text;
            mstr.MAIL = TxtMail.Text;
            mstr.IL = cmbil.Text;
            mstr.ILCE = cmbilce.Text;
            mstr.ADRES = RchAdres.Text;
            dbentity.TBL_MUSTERILER.Add(mstr);
            dbentity.SaveChanges();
            listele();
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Müşteri Sistemden Silinecek.Emin Misiniz?", "Müşteri Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                TBL_MUSTERILER mstr = dbentity.TBL_MUSTERILER.Find(int.Parse(TxtId.Text));
                dbentity.TBL_MUSTERILER.Remove(mstr);
                dbentity.SaveChanges();
                MessageBox.Show("Müşteri sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
             
            }
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {

            TBL_MUSTERILER mstr = dbentity.TBL_MUSTERILER.Find(int.Parse(TxtId.Text));
            mstr.AD = TxtAd.Text;
            mstr.SOYAD = TxtSoyad.Text;
            mstr.TELEFON = MskTelefon1.Text;
            mstr.TELEFON2 = MskTelefon2.Text;
            //mstr.TC = MskTC.Text;
            mstr.TC = TxtTC.Text;
            mstr.MAIL = TxtMail.Text;
            mstr.IL = cmbil.Text;
            mstr.ILCE = cmbilce.Text;
            mstr.ADRES = RchAdres.Text;
            dbentity.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        
       
         }

        

        private void TxtId_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                TBL_MUSTERILER mstr = dbentity.TBL_MUSTERILER.Find(int.Parse(TxtId.Text));
                if (mstr != null)
                {
                    TxtAd.Text = mstr.AD;
                    TxtSoyad.Text = mstr.SOYAD;
                    MskTelefon1.Text = mstr.TELEFON;
                    MskTelefon2.Text = mstr.TELEFON2;
                    TxtTC.Text = mstr.TC;
                   // MskTC.Text = mstr.TC;
                    TxtMail.Text = mstr.MAIL;
                    cmbil.Text = mstr.IL;
                    cmbilce.Text = mstr.ILCE;
                    RchAdres.Text = mstr.ADRES;
                }
            }
        }

        private void TxtTC_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTelefon1.Text = dr["TELEFON"].ToString();
                MskTelefon2.Text = dr["TELEFON2"].ToString();
                TxtTC.Text = dr["TC"].ToString();
                // MskTC.Text = mstr.TC;
                TxtMail.Text = dr["MAIL"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
            }
            
        }

       
        
    }
}
