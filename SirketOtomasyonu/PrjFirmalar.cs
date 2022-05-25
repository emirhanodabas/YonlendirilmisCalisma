using DevExpress.XtraGrid.Views.Grid;
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
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonDataSet.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilcelerTableAdapter.Fill(this.dbo_SirketOtomasyonDataSet.ilceler);
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonDataSet.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.illerTableAdapter.Fill(this.dbo_SirketOtomasyonDataSet.iller);
            FirmaListele();
       
        }
        void FirmaListele()
        {
            gridControl1.DataSource = dbentity.TBL_FIRMALAR.ToList();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtYetkiliGorev.Text = dr["YETKILISTATU"].ToString();
                TxtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
                MskYetkiliTC.Text = dr["YETKILITC"].ToString();
                TxtSektor.Text = dr["SEKTOR"].ToString();
                MskTelefon1.Text = dr["TELEFON1"].ToString();
                MskTelefon2.Text = dr["TELEFON2"].ToString();
                MskTelefon3.Text = dr["TELEFON3"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                MskFax.Text = dr["FAX"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                TxtVergi.Text = dr["VERGIDAIRE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
            }


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
        private void TxtId_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                TBL_FIRMALAR frm = dbentity.TBL_FIRMALAR.Find(int.Parse(TxtId.Text));
                if (frm != null)
                {
                    
                    TxtAd.Text = frm.AD;
                    TxtYetkiliGorev.Text = frm.YETKILISTATU;
                    TxtYetkili.Text = frm.YETKILIADSOYAD;
                    MskYetkiliTC.Text = frm.YETKILITC;
                    TxtSektor.Text = frm.SEKTOR;
                    MskTelefon1.Text = MskTelefon1.Text;
                    MskTelefon2.Text = MskTelefon2.Text;
                    MskTelefon3.Text = MskTelefon3.Text;
                    TxtMail.Text = TxtMail.Text;
                    MskFax.Text = MskFax.Text;
                    cmbil.Text = cmbil.Text;
                    cmbilce.Text = cmbilce.Text;
                    TxtVergi.Text = TxtVergi.Text;
                    RchAdres.Text = RchAdres.Text;
                }
            }
        }
    }
}
