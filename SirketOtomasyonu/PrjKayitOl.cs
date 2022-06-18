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
    public partial class PrjKayitOl : Form
    {
        public PrjKayitOl()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text==txtTekrar.Text)
            {
                TBL_ADMIN adm = new TBL_ADMIN();
                adm.KULLANICIADI = txtkAD.Text;
                adm.SIFRE = txtSifre.Text;
                dbentity.TBL_ADMIN.Add(adm);
                dbentity.SaveChanges();
                MessageBox.Show("Başarılı bir Şekilde kaydoldunuz");
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrjLogin login = new PrjLogin();
            login.Show();
            this.Hide();
        }

        private void PrjKayitOl_Load(object sender, EventArgs e)
        {

        }
    }
}
