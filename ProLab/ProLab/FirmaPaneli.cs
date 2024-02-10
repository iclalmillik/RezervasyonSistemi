using ProLab;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using System.Windows.Forms;
using static ProLab.Araclar;
using static ProLab.Seferler;

namespace ProLab
{
    public partial class Arac : Form
    {
        public List<Araclar> tasit;
        public List<Seferler> SeferListesi;

        public Arac()
        {
            InitializeComponent();
        }

        public Arac(List<Araclar> tasit, List<Seferler> SeferListesi)
        {
            InitializeComponent();

            this.tasit = tasit ?? new List<Araclar>();
            AraclariGoruntule.DataSource = this.tasit;
            AraclariGoruntule.DisplayMember = "id;yakit_turu;yolcu_sayisi";

            this.SeferListesi = SeferListesi ?? new List<Seferler>();
            SeferleriGoruntule.DataSource = this.SeferListesi;
            SeferleriGoruntule.DisplayMember = "SeferNo;UlastirmaTuru;KalkisNoktasi;VarisNoktasi;Tarih";
           
        }

        public string id { get; internal set; }
        public string Id { get; internal set; }
        public string Marka { get; internal set; }

        private void butonaracekle_Click(object sender, EventArgs e)
        {
            string eklenecekId = textIdekle.Text;
            string yakitturu = textyakit.Text;
            string yolcusayisi = textyolcusayisi.Text;


            ConcreteClassA yeniArac = new ConcreteClassA(id: eklenecekId, yakit_turu: yakitturu, yolcu_sayisi: yolcusayisi);


            tasit.Add(yeniArac);

            AraclariGoruntule.DataSource = null;
            AraclariGoruntule.DataSource = tasit;
            AraclariGoruntule.DisplayMember = "id;yakit_turu;yolcu_sayisi";

            textIdekle.Clear();
            textyakit.Clear();
            textyolcusayisi.Clear();
        }

        private void buttonaracsil_Click(object sender, EventArgs e)
        {
            string silinecekAracId = textsilId.Text;


            Araclar silinecekArac = tasit.Find(arac => arac.id == silinecekAracId);

            if (silinecekArac != null)
            {

                tasit.Remove(silinecekArac);


                AraclariGoruntule.DataSource = null;
                AraclariGoruntule.DataSource = tasit;
                AraclariGoruntule.DisplayMember = "id;yakit_turu;yolcu_sayisi";
            }
            else
            {
                MessageBox.Show("Silinecek araç bulunamadı.");
            }

            textsilId.Clear();


        }






        private void ekleseferbuton_Click(object sender, EventArgs e)
        {

            string eklenereden = textnereden.Text;
            string eklenereye = textnereye.Text;
            string ekleulasim = textulasimekle.Text;
            string ekleseferno = textseferekle.Text;

            DateTime seferTarihi = dateTimeekle.Value;
            Seferler yenisefer = new Seferler(seferNo: ekleseferno, ulasimTuru: ekleulasim, kalkisNoktasi: eklenereden, varisNoktasi: eklenereye, tarih: seferTarihi);


            SeferListesi.Add(yenisefer);


            SeferleriGoruntule.DataSource = null;
            SeferleriGoruntule.DataSource = SeferListesi;
            SeferleriGoruntule.DisplayMember = "SeferNo;UlastirmaTuru;KalkisNoktasi;VarisNoktasi;Tarih";


            textnereden.Clear();
            textnereye.Clear();
            textulasimekle.Clear();
            textseferekle.Clear();

        }

        private void silseferbuton_Click(object sender, EventArgs e)
        {
            string silinecekseferNo = textsefernoSil.Text;


            Seferler silineceksefer = SeferListesi.Find(SeferListesi => SeferListesi.SeferNo == silinecekseferNo);

            if (silineceksefer != null)
            {

                SeferListesi.Remove(silineceksefer);


               SeferleriGoruntule.DataSource = null;
                SeferleriGoruntule.DataSource = SeferListesi;
                SeferleriGoruntule.DisplayMember = "SeferNo;UlastirmaTuru;KalkisNoktasi;VarisNoktasi;Tarih";
            }
            else
            {
                MessageBox.Show("Silinecek sefer bulunamadı.");
            }

            textsilId.Clear();


        }
    }
}




