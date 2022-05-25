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
    public partial class PrjHareketler : Form
    {
        public PrjHareketler()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        void firmaHareket()
        {
            //gridControlfirma.DataSource = dbentity.TBL_FIRMAHAREKET.ToList();
            gridControlfirma.DataSource = dbentity.TBL_FIRMAHAREKET.Select(y => new
            {
                y.TBL_URUNLER.URUNAD,
                y.ADET,
                PERSONELAD=y.TBL_PERSONELLER.AD,
                PESONELSOYAD=y.TBL_PERSONELLER.SOYAD,
                FİRMA=y.TBL_FIRMALAR.AD,
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
        private void PrjHareketler_Load(object sender, EventArgs e)
        {
          
            firmaHareket();
            musteriHareket();
           
        }
    }
}
