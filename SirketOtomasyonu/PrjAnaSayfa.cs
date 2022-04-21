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
    public partial class PrjAnaSayfa : Form
    {
        public PrjAnaSayfa()
        {
            InitializeComponent();
        }

        private void PrjAnaSayfa_Load(object sender, EventArgs e)
        {
           
                this.webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
                //this.webBrowser2.Navigate("https://www.doviz.com/kripto-paralar"); 
          

        }

       
    }

}