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
    public partial class PrjKasa : Form
    {
        public PrjKasa()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();

        void firmaHareket()
        {
            //gridControlfirma.DataSource = dbentity.TBL_FIRMAHAREKET.ToList();
            gridControlFirma.DataSource = dbentity.TBL_FIRMAHAREKET.Select(y => new
            {
                y.TBL_URUNLER.URUNAD,
                y.ADET,
                PERSONELAD = y.TBL_PERSONELLER.AD,
                PESONELSOYAD = y.TBL_PERSONELLER.SOYAD,
                FİRMA = y.TBL_FIRMALAR.AD,
                y.FIYAT,
                y.TOPLAM,
                y.FATURAID,
                y.TARIH,
                y.NOTLAR
            }).ToList();
        }
        void musteriHareket()
        {
            //gridControlMusteri.DataSource = dbentity.TBL_MUSTERIHAREKET.ToList();
            gridControlMusteri.DataSource = dbentity.TBL_MUSTERIHAREKET.Select(x => new
            {
                x.TBL_URUNLER.URUNAD,
                x.ADET,
                PERSONELAD = x.TBL_PERSONELLER.AD,
                PESONELSOYAD = x.TBL_PERSONELLER.SOYAD,
                Musteri = x.TBL_MUSTERILER.AD,
                MusteriSoyad = x.TBL_MUSTERILER.SOYAD,
                x.FIYAT,
                x.TOPLAM,
                x.FATURAID,
                x.TARIH,
                x.NOTLAR
            }).ToList();

        }
        void personelbilgi()
        {
            gridControlpersonel.DataSource = dbentity.TBL_PERSONELLER.Select(y => new
            {
                y.ID,
                y.AD,
                y.SOYAD,
                y.MAAS
            }).ToList();
        }
        void gider()
        {
            gridControlgider.DataSource = dbentity.TBL_GIDERLER.Select(g => new
            {
                g.ID,
                g.INTERNET,
                g.SU,
                g.DOGALGAZ,
                g.ELEKTRIK,
                g.EKSTRA
            }).ToList();
        }
        void topTutar()
        {
            var firmatop = dbentity.TBL_FIRMAHAREKET.Sum(p => p.TOPLAM);
            var musteritop = dbentity.TBL_MUSTERIHAREKET.Sum(p => p.TOPLAM);
            var toplam = firmatop + musteritop;
            LblTopTutar.Text = toplam.ToString();

        }
        public void persmaas()
        {
            var maas = dbentity.TBL_PERSONELLER.Sum(m => m.MAAS);
            LblPersMaas.Text = maas.ToString();
        }
        void persAdet()
        {
            var adet = dbentity.TBL_PERSONELLER.Count();

            LblPersSay.Text = adet.ToString();

        }
        void giderlerTop()
        {
            var gider = dbentity.TBL_GIDERLER.Sum(p => p.INTERNET);
            var gider1 = dbentity.TBL_GIDERLER.Sum(p => p.SU);
            var gider2 = dbentity.TBL_GIDERLER.Sum(p => p.DOGALGAZ);
            var gider3 = dbentity.TBL_GIDERLER.Sum(p => p.ELEKTRIK);
            var gider4 = dbentity.TBL_GIDERLER.Sum(p => p.EKSTRA);

            var toplam = gider + gider1 + gider2 + gider3 + gider4;

            LblTopGider.Text = toplam.ToString();
        }
        protected override void OnScroll(ScrollEventArgs se)
        {
           
            gider();
            giderlerTop();
            personelbilgi();
            firmaHareket();
            musteriHareket();
            topTutar();
            persmaas();
            persAdet();
            base.OnScroll(se);

        }
        private void Kasa_Load(object sender, EventArgs e)
        {
            gider();
            giderlerTop();
            personelbilgi();
            firmaHareket();
            musteriHareket();
            topTutar();
            persmaas();
            persAdet();

        }


    }
}
