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
    public partial class PrjFaturaUrunDetay : Form
    {
        public PrjFaturaUrunDetay()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        public string id;
        public void listele()
        {

            int ID = Convert.ToInt32(id);
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
            gridControl1.DataSource = dbentity.TBL_FATURADETAY.Select(y => new
            {
                y.FATURAURUNID,
                y.URUNAD,
                y.MIKTAR,
                y.TUTAR,
                y.FIYAT,
                y.FATURAID
            }).ToList();

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

        }
        private void PrjFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            //listele();
        }
    }
}
