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
    public partial class PrjPersoneller : Form
    {
        public PrjPersoneller()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();

        void personelListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }       
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            personelListele();
            
        }

        
    }
}
