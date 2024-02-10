using System;
using System.Collections.Generic;

namespace ProLab
{
    public class Firma : User
    {
        public Seferler Seferler = new Seferler();
        public List<Seferler> seferListesi = new List<Seferler>();
        public float HizmetBedeli { get; set; }
        public string? FirmaIsim { get; set; } // Nullable string olarak tanımlandı


        public Firma(float hizmetBedeli, string kullaniciAdi, string sifre)
            : base(kullaniciAdi, sifre)
        {
            this.HizmetBedeli = hizmetBedeli;
        }

        public Firma(string? firmaIsim) // Nullable string olarak tanımlandı
            : base("defaultKullaniciAdi", "defaultSifre")
        {
            this.FirmaIsim = firmaIsim;
        }

        public Firma()
            : base("defaultKullaniciAdi", "defaultSifre")
        {

        }




        public override void Login()
        {

        }

        public void GunlukKar()
        {

        }

        public void GunlukZarar()
        {

        }
    }
}