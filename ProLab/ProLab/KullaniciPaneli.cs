using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProLab
{
    public partial class KullaniciPaneli : Form
    {
        public KullaniciPaneli()
        {
            InitializeComponent();
        }
        public static class MusteriBilgileri
        {
            public static string müsteriAdi;
            public static string tc;
            public static string Cinsiyet;
            public static string nereden;
            public static string nereye;
            public static string tarih;
            public static string fiyat;
            public static string koltuk;
        }

        
        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboOtobus.Text)
            {

                case "A Firmasi -Otobüs1":
                    KoltukDoldur(40, true);
                    break;
                case "A Firmasi-Otobüs2":
                    KoltukDoldur(30, false);
                    break;
                case "B Firmasi-Otobüs1":
                    KoltukDoldur(30, true);
                    break;
                case "B Firmasi-Otobüs2":
                    KoltukDoldur(40, false);
                    break;
                case "C Firmasi-Otobüs1":
                    KoltukDoldur(40, true);
                    break;
                case "C Firmasi-Ucak1":
                    KoltukDoldur(60, true);
                    break;
                case "C Firmasi-Ucak2":
                    KoltukDoldur(60, false);
                    break;
                case "D Firmasi-Tren1":
                    KoltukDoldur(50, true);
                    break;
                case "D Firmasi-Tren2":
                    KoltukDoldur(50, false);
                    break;
                case "D Firmasi-Tren3":
                    KoltukDoldur(50, true);
                    break;
                case "F Firmasi-Ucak1":
                    KoltukDoldur(60, true);
                    break;
                case "F Firmasi-Ucak2":
                    KoltukDoldur(60, false);
                    break;
            }
            void KoltukDoldur(int sira, bool arkaBesliMi)
            {
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 5;
                tableLayoutPanel1.RowCount = sira / 5;
                System.Windows.Forms.Button btn;
                int buttonWidth = 50;
                int buttonHeight = 30;
                int padding = 1;
                int counter = 1;
                for (int i = 0; i < sira / 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        btn = new System.Windows.Forms.Button();
                        btn.Text = counter.ToString();
                        btn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                        btn.Margin = new Padding(padding);
                        btn.Click += new EventHandler(Button_Click); // Buton tıklama olayı
                        Random rnd = new Random();
                        int rastgeleYolcu = rnd.Next(0, 5);
                        if (rastgeleYolcu == 2)
                            btn.BackColor = Color.Red;
                        else
                            btn.BackColor = Color.Green;
                        tableLayoutPanel1.Controls.Add(btn, i, j);
                        counter++;
                    }
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            if (clickedButton.BackColor == Color.Green)
            {
                MessageBox.Show(clickedButton.Text + " numaralı koltuk seçildi! Ödeme formuna yönlendiriliyorsunuz.");
                MusteriBilgileri.koltuk = clickedButton.Text;
                Kayıt_Formu form1 = new Kayıt_Formu();
                form1.Show();
            }
            else
            {
                MessageBox.Show(clickedButton.Text + " numaralı koltuk dolu.Lütfen başka koltuk seçiniz.!");
            }
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (MusteriBilgileri.koltuk != null)
            {
                MusteriBilgileri.tarih = dateTimeTarih.ToString();
                MusteriBilgileri.fiyat = txtFiyat.Text;
                string[] row = { MusteriBilgileri.müsteriAdi, MusteriBilgileri.tc, MusteriBilgileri.Cinsiyet, MusteriBilgileri.nereden, MusteriBilgileri.nereye, MusteriBilgileri.koltuk, MusteriBilgileri.tarih.ToString(), MusteriBilgileri.fiyat };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
            }
            else
            {
                MessageBox.Show("Koltuk seçilmediği için işleme devam edilemiyor.Lütfen koltuk seçiniz.");
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriBilgileri.nereden = comboNereden.SelectedItem.ToString();
            MessageBox.Show(MusteriBilgileri.nereden);
        }

        private void comboNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriBilgileri.nereye = comboNereye.SelectedItem.ToString();
            //Tüm Otobüs Seferleri
            if (MusteriBilgileri.nereden == "İstanbul" && comboOtobus.SelectedItem.ToString().Contains("Otobüs") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "Kocaeli":
                        MusteriBilgileri.fiyat = "50";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Ankara":
                        MusteriBilgileri.fiyat = "300";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Eskişehir":
                        MusteriBilgileri.fiyat = "150";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Konya":
                        MusteriBilgileri.fiyat = "300";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
            else if (MusteriBilgileri.nereden == "Kocaeli" && comboOtobus.SelectedItem.ToString().Contains("Otobüs") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "İstanbul":
                        MusteriBilgileri.fiyat = "50";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Ankara":
                        MusteriBilgileri.fiyat = "400";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Eskişehir":
                        MusteriBilgileri.fiyat = "150";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Konya":
                        MusteriBilgileri.fiyat = "300";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
            else if (MusteriBilgileri.nereden == "Ankara" && comboOtobus.SelectedItem.ToString().Contains("Otobüs") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "İstanbul":
                        MusteriBilgileri.fiyat = "300";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Kocaeli":
                        MusteriBilgileri.fiyat = "400";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
            else if (MusteriBilgileri.nereden == "Eskişehir" && comboOtobus.SelectedItem.ToString().Contains("Otobüs") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "İstanbul":
                        MusteriBilgileri.fiyat = "150";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Kocaeli":
                        MusteriBilgileri.fiyat = "100";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
            else if (MusteriBilgileri.nereden == "Konya" && comboOtobus.SelectedItem.ToString().Contains("Otobüs") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "İstanbul":
                        MusteriBilgileri.fiyat = "300";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Kocaeli":
                        MusteriBilgileri.fiyat = "250";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Eskişehir":
                        MusteriBilgileri.fiyat = "150";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
            //Otobüs Seferleri Bitti
            //Tren Seferleri
            else if (MusteriBilgileri.nereden == "İstanbul" && comboOtobus.SelectedItem.ToString().Contains("Tren") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "Kocaeli":
                        MusteriBilgileri.fiyat = "50";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Bilecik":
                        MusteriBilgileri.fiyat = "150";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Ankara":
                        MusteriBilgileri.fiyat = "250";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Eskişehir":
                        MusteriBilgileri.fiyat = "200";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Konya":
                        MusteriBilgileri.fiyat = "300";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
            else if (MusteriBilgileri.nereden == "Kocaeli" && comboOtobus.SelectedItem.ToString().Contains("Tren") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "İstanbul":
                        MusteriBilgileri.fiyat = "50";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Bilecik":
                        MusteriBilgileri.fiyat = "150";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Ankara":
                        MusteriBilgileri.fiyat = "200";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Eskişehir":
                        MusteriBilgileri.fiyat = "100";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Konya":
                        MusteriBilgileri.fiyat = "250";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
            else if (MusteriBilgileri.nereden == "Bilecik" && comboOtobus.SelectedItem.ToString().Contains("Tren") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "İstanbul":
                        MusteriBilgileri.fiyat = "150";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Kocaeli":
                        MusteriBilgileri.fiyat = "50";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Ankara":
                        MusteriBilgileri.fiyat = "200";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Eskişehir":
                        MusteriBilgileri.fiyat = "100";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Konya":
                        MusteriBilgileri.fiyat = "250";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
            else if (MusteriBilgileri.nereden == "Ankara" && comboOtobus.SelectedItem.ToString().Contains("Tren") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "İstanbul":
                        MusteriBilgileri.fiyat = "250";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Kocaeli":
                        MusteriBilgileri.fiyat = "200";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Bilecik":
                        MusteriBilgileri.fiyat = "150";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Eskişehir":
                        MusteriBilgileri.fiyat = "100";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
            else if (MusteriBilgileri.nereden == "Eskişehir" && comboOtobus.SelectedItem.ToString().Contains("Tren") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "İstanbul":
                        MusteriBilgileri.fiyat = "200";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Kocaeli":
                        MusteriBilgileri.fiyat = "100";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Bilecik":
                        MusteriBilgileri.fiyat = "50";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Ankara":
                        MusteriBilgileri.fiyat = "100";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Konya":
                        MusteriBilgileri.fiyat = "150";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
            else if (MusteriBilgileri.nereden == "Konya" && comboOtobus.SelectedItem.ToString().Contains("Tren") == true)
            {
                switch (comboNereye.SelectedItem.ToString())
                {
                    case "İstanbul":
                        MusteriBilgileri.fiyat = "300";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Kocaeli":
                        MusteriBilgileri.fiyat = "250";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Bilecik":
                        MusteriBilgileri.fiyat = "200";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                    case "Eskişehir":
                        MusteriBilgileri.fiyat = "150";
                        txtFiyat.Text = MusteriBilgileri.fiyat;
                        break;
                }
            }
        }

        private void dateTimeTarih_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

