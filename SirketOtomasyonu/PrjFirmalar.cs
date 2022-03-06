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
    public partial class PrjFirmalar : Form
    {
        public PrjFirmalar()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
    
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            
        }
       
    }
}
