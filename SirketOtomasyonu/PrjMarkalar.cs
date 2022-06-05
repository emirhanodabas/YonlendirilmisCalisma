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
    public partial class PrjMarkalar : Form
    {
        public PrjMarkalar()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        private void PrjMarkalar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonKategori.TBL_KATEGORILER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_KATEGORILERTableAdapter.Fill(this.dbo_SirketOtomasyonKategori.TBL_KATEGORILER);

            listele();
          
        }
        void listele()
        {
            gridControlMarka.DataSource = dbentity.TBL_MARKALAR.Select(x=> new {
                x.ID,
                x.TBL_KATEGORILER.ADI,
                x.MARKA
            }).ToList();
        }
       
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_MARKALAR mrk = new TBL_MARKALAR();
            mrk.KATEGORI = int.Parse(cmbKategori.Text);
            mrk.MARKA = TxtMarka.Text;
            dbentity.TBL_MARKALAR.Add(mrk);
            dbentity.SaveChanges();
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Ürünü Sistemden Silinecek.Emin Misiniz?", "Ürün Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                TBL_MARKALAR mrk = dbentity.TBL_MARKALAR.Find(int.Parse(TxtId.Text));
                dbentity.TBL_MARKALAR.Remove(mrk);
                dbentity.SaveChanges();
                MessageBox.Show("Ürün sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            TBL_MARKALAR mrk = dbentity.TBL_MARKALAR.Find(int.Parse(TxtId.Text));
            mrk.KATEGORI = int.Parse(cmbKategori.Text);
            mrk.MARKA = TxtMarka.Text;
            dbentity.SaveChanges();
            MessageBox.Show("Marka Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                TBL_MARKALAR mrk = dbentity.TBL_MARKALAR.Find(int.Parse(TxtId.Text));
                if (mrk != null)
                {
                    cmbKategori.Text = (mrk.KATEGORI).ToString();
                 
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            cmbKategori.Text = "";
            TxtMarka.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
           
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
        }
    }
}
