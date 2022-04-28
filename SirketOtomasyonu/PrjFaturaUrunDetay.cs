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
        void listele()
        {
            gridControl1.DataSource = dbentity.TBL_FATURADETAY.ToList();
        }
        private void PrjFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
