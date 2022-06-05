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
    public partial class PrjKategoriler : Form
    {
        public PrjKategoriler()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        void listele()
        {
            gridControl1.DataSource = dbentity.TBL_KATEGORILER.Select(x=> new {
                x.ID,
                x.ADI
            }).ToList();
        }

        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_KATEGORILER ktgr = new TBL_KATEGORILER();
            ktgr.ADI = txtKategori.Text;
            dbentity.TBL_KATEGORILER.Add(ktgr);
            dbentity.SaveChanges();
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Ürünü Sistemden Silinecek.Emin Misiniz?", "Ürün Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                TBL_KATEGORILER ktgr = dbentity.TBL_KATEGORILER.Find(int.Parse(TxtId.Text));
                dbentity.TBL_KATEGORILER.Remove(ktgr);
                dbentity.SaveChanges();
                MessageBox.Show("Ürün sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
           
                TBL_KATEGORILER ktgr = dbentity.TBL_KATEGORILER.Find(int.Parse(TxtId.Text));
                ktgr.ADI = txtKategori.Text;
                dbentity.SaveChanges();
                MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            
        }

        

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            txtKategori.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtKategori.Text = gridView1.GetFocusedRowCellValue("ADI").ToString();
        }
    }
}
