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
    public partial class PrjGiderler : Form
    {
        public PrjGiderler()
        {
            InitializeComponent();
        }
       Sqlbaglanti bgl = new Sqlbaglanti();
       void giderlistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from TBL_GIDERLER", bgl.baglanti());
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            giderlistesi();
        }
    }
}
