using System;
using System.Collections.Generic;

namespace ProLab
{
    public class Seferler
    {
        public List<Arac> Araclar { get; set; } = new List<Arac>();
        public string SeferNo { get; set; }
        public string UlastirmaTuru { get; set; }
        public string KalkisNoktasi { get; set; }
        public string VarisNoktasi { get; set; }
        public DateTime Tarih { get; set; }
        public override string ToString()
        {
            return $"{SeferNo}; {UlastirmaTuru}; {KalkisNoktasi};{VarisNoktasi};{Tarih}";
        }

        List<Seferler> SeferlerListesi = new List<Seferler>();

        public Seferler(string seferNo, string ulasimTuru, string kalkisNoktasi, string varisNoktasi, DateTime tarih)
        {
            SeferNo = seferNo;
            UlastirmaTuru = ulasimTuru;
            KalkisNoktasi = kalkisNoktasi;
            VarisNoktasi = varisNoktasi;
            Tarih = tarih;

        }

        public Seferler()
        {
        }

       
    }
}
