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
using SirketOtomasyonu.DbIslemler;

namespace SirketOtomasyonu
{
    public partial class PrjMusteriler :Form
    {
        public PrjMusteriler()
        {
            InitializeComponent();
        }
        
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
        
        }
       
        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                Txtid.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTelefon1.Text = dr["TELEFON"].ToString();
                MskTelefon2.Text = dr["TELEFON2"].ToString();
                MskTC.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
            }
        }
    }
}
