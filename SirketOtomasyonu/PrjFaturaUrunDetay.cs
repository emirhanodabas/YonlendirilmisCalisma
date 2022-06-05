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
    public partial class PrjFaturaUrunDetay : Form
    {
        public PrjFaturaUrunDetay()
        {
            InitializeComponent();
        }
        public string id;
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        Sqlbaglanti bgl = new Sqlbaglanti();
        
        public void listele()
        {


            //var liste = dbentity.TBL_FATURADETAY.Where(x => x.FATURAID ==ID).Select(y=>new
            //{
            //    y.FATURAURUNID,
            //    y.URUNAD,
            //    y.MIKTAR,
            //    y.TUTAR,
            //    y.FIYAT,
            //    y.FATURAID
            //}).ToList();
            //gridControl1.DataSource = dbentity.TBL_FATURADETAY.Where(x => x.FATURAID ==ID).Select(y => new
            //{
            //    y.FATURAURUNID,
            //    y.URUNAD,
            //    y.MIKTAR,
            //    y.TUTAR,
            //    y.FIYAT,
            //    y.FATURAID
            //}).ToList(); 
            //gridControl1.DataSource = dbentity.TBL_FATURADETAY.Select(y => new
            //{
            //    y.FATURAURUNID,
            //    y.URUNAD,
            //    y.MIKTAR,
            //    y.TUTAR,
            //    y.FIYAT,
            //    y.FATURAID
            //}).ToList();

            //var liste = (from q in dbentity.TBL_FATURADETAY
            //             where q.FATURAID == ID
            //             select new
            //             {
            //                 q.FATURAURUNID,
            //                 q.URUNAD,
            //                 q.MIKTAR,
            //                 q.TUTAR,
            //                 q.FIYAT,
            //                 q.FATURAID
            //             });
            //gridControl1.DataSource = liste.ToList();
            //SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FATURADETAY where FATURAID='" + id + "'", bgl.baglanti());
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //gridControl1.DataSource = dt;
            //gridControl1.DataSource = dbentity.TBL_FATURADETAY.ToList();
            gridControl1.DataSource = dbentity.TBL_FATURADETAY.ToList();
        }
        private void PrjFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            
            listele();
        }
    }
}
