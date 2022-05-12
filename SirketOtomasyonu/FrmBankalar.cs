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
namespace SirketOtomasyon
{
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            Txtid.Text = "";
            TxtBankaAd.Text = "";
            TxtSube.Text = "";
            TxtIban.Text = "";
            TxtHesapNo.Text = "";
            TxtYetkili.Text = "";
            MskTarih.Text = "";
            TxtHesapTuru.Text = "";
            cmbFirma.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            MskTelefon.Text = "";
        }
        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID,AD from TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            cmbFirma.Properties.ValueMember = "ID";
            cmbFirma.Properties.DisplayMember = "AD";
            cmbFirma.Properties.DataSource = dt;
        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            firmaListesi();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" insert into TBL_BANKALAR " +
                                              " (BANKAADI,SUBE,IBAN,HESAPNO,YETKILI,TARIH,HESAPTURU,FIRMAID,IL,ILCE,TELEFON) values " +
                                              " (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11) ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",  TxtBankaAd.Text);
            komut.Parameters.AddWithValue("@p2",  TxtSube.Text);
            komut.Parameters.AddWithValue("@p3",  TxtIban.Text);
            komut.Parameters.AddWithValue("@p4",  TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@p5",  TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p6",  MskTarih.Text);
            komut.Parameters.AddWithValue("@p7",  TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p8",  cmbFirma.EditValue);
            komut.Parameters.AddWithValue("@p9",  cmbil.Text);
            komut.Parameters.AddWithValue("@p10", cmbilce.Text);
            komut.Parameters.AddWithValue("@p11", MskTelefon.Text);

            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bigisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                Txtid.Text = dr["ID"].ToString();
                TxtBankaAd.Text = dr["BANKAADI"].ToString();
                TxtSube.Text = dr["SUBE"].ToString();
                TxtIban.Text = dr["IBAN"].ToString();
                TxtHesapNo.Text = dr["HESAPNO"].ToString();
                TxtYetkili.Text = dr["YETKILI"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                TxtHesapTuru.Text = dr["HESAPTURU"].ToString();
                //cmbFirma.Text = dr["FIRMAID"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                MskTelefon.Text = dr["TELEFON"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Banka Sistemden Silinecek.Emin Misiniz?", "Banka Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komutSil = new SqlCommand("delete TBL_BANKALAR where ID=@p1", bgl.baglanti());

                komutSil.Parameters.AddWithValue("@p1", Txtid.Text);
                komutSil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Banka sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_BANKALAR set " +
                                             " BANKAADI=@p1, SUBE=@p2,IBAN=@p3,HESAPNO=@p4,YETKILI=@p5,TARIH=@p6,HESAPTURU=@p7,FIRMAID=@p8,IL=@p9,ILCE=@p10,TELEFON=@p11 " +
                                             " where ID=@p12 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBankaAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSube.Text);
            komut.Parameters.AddWithValue("@p3", TxtIban.Text);
            komut.Parameters.AddWithValue("@p4", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@p5", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p6", MskTarih.Text);
            komut.Parameters.AddWithValue("@p7", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p8", cmbFirma.EditValue);
            komut.Parameters.AddWithValue("@p9", cmbil.Text);
            komut.Parameters.AddWithValue("@p10", cmbilce.Text);
            komut.Parameters.AddWithValue("@p11", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p12", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
