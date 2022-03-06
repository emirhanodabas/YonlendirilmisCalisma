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
    public partial class PrjAnaModul : Form
    {
        public PrjAnaModul()
        {
            InitializeComponent();
        }
        PrjAnaSayfa anasyf;
        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anasyf == null)
            {
                anasyf = new PrjAnaSayfa();
                anasyf.MdiParent = this;
                anasyf.Show();
            }
        }
        PrjUrunler pr;
        private void BtnUrunle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pr == null)
            {
                pr = new PrjUrunler();
                pr.MdiParent = this;
                pr.Show();
            }
        }
        PrjMusteriler pr2;
        private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pr2 == null)
            {
                pr2 = new PrjMusteriler();
                pr2.MdiParent = this;
                pr2.Show();
            }
        }

        PrjFirmalar pr3;
        private void BtnFirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pr3 == null)
            {
                pr3 = new PrjFirmalar();
                pr3.MdiParent = this;
                pr3.Show();
            }
        }

        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            if (anasyf == null)
            {
                anasyf = new PrjAnaSayfa();
                anasyf.MdiParent = this;
                anasyf.Show();
            }
        }

        PrjPersoneller pr4;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pr4 == null)
            {
                pr4 = new PrjPersoneller();
                pr4.MdiParent = this;
                pr4.Show();
            }
        }
        PrjKategoriler pr5;
        private void BtnKategoriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pr5 == null)
            {
                pr5 = new PrjKategoriler();
                pr5.MdiParent = this;
                pr5.Show();
            }
        }
        PrjMarkalar pr6;
        private void BtnMarkalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pr6 == null)
            {
                pr6 = new PrjMarkalar();
                pr6.MdiParent = this;
                pr6.Show();
            }
        }
        PrjGiderler gdr1;
        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gdr1 == null)
            {
                gdr1 = new PrjGiderler();
                gdr1.MdiParent = this;
                gdr1.Show();

            }
        }
        PrjKasa kasa;
        private void BtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasa == null)
            {
                kasa = new PrjKasa();
                kasa.MdiParent = this;
                kasa.Show();
            }
        }

        PrjBankalar bnk;
        private void BtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bnk == null)
            {
                bnk = new PrjBankalar();
                bnk.MdiParent = this;
                bnk.Show();
            }
        }
        PrjHareketler hrk;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hrk == null)
            {
                hrk = new PrjHareketler();
                hrk.MdiParent = this;
                hrk.Show();
            }
        }
        PrjFaturalar ftr;
        private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ftr == null)
            {
                ftr = new PrjFaturalar();
                ftr.MdiParent = this;
                ftr.Show();
            }
        }
        PrjRehber rhb;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rhb == null)
            {
                rhb = new PrjRehber();
                rhb.MdiParent = this;
                rhb.Show();
            }
        }
        PrjRapor rpr;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rpr == null)
            {
                rpr = new PrjRapor();
                rpr.MdiParent = this;
                rpr.Show();
            }
        }
        PrjSiparis spr;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (spr == null)
            {
                spr = new PrjSiparis();
                spr.MdiParent = this;
                spr.Show();
            }
        }
        
    }
}
