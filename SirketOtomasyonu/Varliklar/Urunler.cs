using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.Varliklar
{
    class Urunler:IVarlik
    {
        private int id;
        private string urunadi;
        private string model;
        private string marka;
        private string yil;
        private int adet;
        private decimal alisfiyat;
        private decimal satisfiyat;
        private string kategori;
        private string detay;

        public int Id { get => id; set => id = value; }
        public string Urunadi { get => urunadi; set => urunadi = value; }
        public string Model { get => model; set => model = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Yil { get => yil; set => yil = value; }
        public int Adet { get => adet; set => adet = value; }
        public decimal Alisfiyat { get => alisfiyat; set => alisfiyat = value; }
        public decimal Satisfiyat { get => satisfiyat; set => satisfiyat = value; }
        public string Kategori { get => kategori; set => kategori = value; }
        public string Detay { get => detay; set => detay = value; }
    }
}
