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
using DevExpress.Charts;
using System.Collections;

namespace SirketOtomasyonu
{
    public partial class PrjKasa : Form
    {
        public PrjKasa()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        Sqlbaglanti bgl = new Sqlbaglanti();
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
        void kasaCikis()
        {
            gridControl2.DataSource = (from x in dbentity.TBL_GIDERLER
                                       select new
                                       {
                                           x.AY,
                                           x.DOGALGAZ,
                                           x.ELEKTRIK,
                                           x.INTERNET,
                                           x.SU,
                                           x.MAASLAR,
                                           x.EKSTRA
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
        void musteriAdet()
        {
            var adet = dbentity.TBL_MUSTERILER.Count();
            LblMusSay.Text = adet.ToString();
        }
        //void sehirAdet()
        //{

        //    var adet = dbentity.TBL_MUSTERILER.Select(x => new {
        //        x.IL
        //    }).Distinct().Count();
        //    LblSehirSay.Text = adet.ToString();
        //}
        void firmaAdet()
        {
            var adet = dbentity.TBL_FIRMALAR.Count();
            LblFirSay.Text = adet.ToString();
            LblFirSay.Refresh();
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
        void chart()
        {
            
            //ArrayList xvalue = new ArrayList();
            //ArrayList yvalue = new ArrayList();
            //var veriler = dbentity.TBL_GIDERLER.ToList();
            //veriler.ToList().ForEach(x => xvalue.Add(x.AY));
            //veriler.ToList().ForEach(y => yvalue.Add(y.DOGALGAZ));
            //chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(xvalue,yvalue));
          
            
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
            musteriAdet();
            firmaAdet();
            
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
            musteriAdet();
            firmaAdet();
            chart();
            kasaCikis();
            
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            //ELEKTRIK
            if (sayac>0 && sayac<=5)
            {
                groupControl8.Text = "ELEKTRIK";
                SqlCommand komut1 = new SqlCommand("Select top 6 AY,ELEKTRIK from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr = komut1.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglanti().Close();
            }
            //SU
            if (sayac>5 && sayac<=10)
            {
                groupControl8.Text = "SU";

                chartControl2.Series["AYLAR"].Points.Clear();
                SqlCommand komut2 = new SqlCommand("Select top 6 AY,SU from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr2[0], dr2[1]));
                }
                bgl.baglanti().Close();
            }
            //İnternet
            if (sayac > 10 && sayac <= 15)
            {
                groupControl8.Text = "INTERNET";

                chartControl2.Series["AYLAR"].Points.Clear();
                SqlCommand komut3 = new SqlCommand("Select top 6 AY,INTERNET from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr3[0], dr3[1]));
                }
                bgl.baglanti().Close();
            }
            //Doğalgaz
            if (sayac > 15 && sayac <= 20)
            {
                groupControl8.Text = "DOGALGAZ";

                chartControl2.Series["AYLAR"].Points.Clear();
                SqlCommand komut3 = new SqlCommand("Select top 6 AY,DOGALGAZ from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr3[0], dr3[1]));
                }
                bgl.baglanti().Close();
            }
            //Ekstra
            if (sayac > 20 && sayac <= 25)
            {
                groupControl8.Text = "EKSTRA";

                chartControl2.Series["AYLAR"].Points.Clear();
                SqlCommand komut3 = new SqlCommand("Select top 6 AY,EKSTRA from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr3[0], dr3[1]));
                }
                bgl.baglanti().Close();
            }

        }
        int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            //ELEKTRIK
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl9.Text = "ELEKTRIK";
                SqlCommand komut1 = new SqlCommand("Select top 6 AY,ELEKTRIK from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr = komut1.ExecuteReader();
                while (dr.Read())
                {
                    chartControl3.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglanti().Close();
            }
            //SU
            if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl9.Text = "SU";

                chartControl3.Series["AYLAR"].Points.Clear();
                SqlCommand komut2 = new SqlCommand("Select top 6 AY,SU from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    chartControl3.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr2[0], dr2[1]));
                }
                bgl.baglanti().Close();
            }
            //İnternet
            if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl9.Text = "INTERNET";

                chartControl3.Series["AYLAR"].Points.Clear();
                SqlCommand komut3 = new SqlCommand("Select top 6 AY,INTERNET from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    chartControl3.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr3[0], dr3[1]));
                }
                bgl.baglanti().Close();
            }
            //Doğalgaz
            if (sayac2 > 15 && sayac2 <= 20)
            {
                groupControl9.Text = "DOGALGAZ";

                chartControl3.Series["AYLAR"].Points.Clear();
                SqlCommand komut3 = new SqlCommand("Select top 6 AY,DOGALGAZ from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    chartControl3.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr3[0], dr3[1]));
                }
                bgl.baglanti().Close();
            }
            //Ekstra
            if (sayac2 > 20 && sayac2 <= 25)
            {
                groupControl9.Text = "EKSTRA";

                chartControl3.Series["AYLAR"].Points.Clear();
                SqlCommand komut3 = new SqlCommand("Select top 6 AY,EKSTRA from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    chartControl3.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr3[0], dr3[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2==26)
            {
                sayac2 = 0;
            }
        }
    }
}
