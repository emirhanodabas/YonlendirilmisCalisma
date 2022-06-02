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
    public partial class PrjStok : Form
    {
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        public PrjStok()
        {
            InitializeComponent();
        }

        void listele()
        {
            var top = dbentity.TBL_URUNLER.OrderBy(x => x.ADET).GroupBy(y => y.URUNAD).Select(z => new { URUNAD = z.Key, Toplam = z.Sum(s=>s.ADET) });
            gridControl1.DataSource = top.ToList();
        }
        void chart()
        {
            Sqlbaglanti bgl = new Sqlbaglanti();
            SqlCommand kmt = new SqlCommand("Select URUNAD,Sum(ADET) from TBL_URUNLER group by URUNAD", bgl.baglanti());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), Convert.ToInt16(dr[1].ToString()));
            }
            bgl.baglanti().Close();
        }
        private void PrjStok_Load(object sender, EventArgs e)
        {
            listele();
            chart();
        }
    }
}
