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
    public partial class PrjLogin : Form
    {
        public PrjLogin()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        int hak = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            
            var sorgu = from x in dbentity.TBL_ADMIN
                        where x.KULLANICIADI ==
                        txtKullanciAD.Text & x.SIFRE == txtSifre.Text
                        select x;
            if (txtKullanciAD.Text==""|| txtSifre.Text=="" )
            {
                MessageBox.Show("boş alan bıraktınız lütfen dolduruuz");
            }
            else
            {
                if (sorgu.Any())
                {
                    PrjAnaModul anaSayfa = new PrjAnaModul();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    hak--;
                    MessageBox.Show("hatalı giriş kalan hakkınız=" + hak,"Uyarı2");
                    if (hak == 0)
                    {
                        MessageBox.Show("giriş hakkınız kalmadı programdan çıkılıyor...");
                        Application.Exit();
                    }
                }
            }
            
        }
       

        private void PrjLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrjKayitOl kayitOl = new PrjKayitOl();
            kayitOl.Show();
            this.Hide();
        }
    }
}
