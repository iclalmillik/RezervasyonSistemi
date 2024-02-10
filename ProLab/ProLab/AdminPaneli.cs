using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProLab
{
    public partial class AdminPaneli : Form
    {
        List<Firma> firmalar = new List<Firma>();

        public AdminPaneli()
        {
            InitializeComponent();

        }
        public AdminPaneli(List<Firma> firmalar)
        {
            InitializeComponent();

            this.firmalar = firmalar ?? new List<Firma>();
            FirmalariGoruntule.DataSource = this.firmalar;
            FirmalariGoruntule.DisplayMember = "FirmaIsim";


        }

        private void firmaEkleBtn_Click(object sender, EventArgs e)
        {

            string yeniFirmaIsim = firmaEkleText.Text;
            Firma yeniFirma = new Firma { FirmaIsim = yeniFirmaIsim };

            firmalar.Add(yeniFirma);

            FirmalariGoruntule.DataSource = null;
            FirmalariGoruntule.DataSource = firmalar;
            FirmalariGoruntule.DisplayMember = "FirmaIsim";


            firmaEkleText.Clear();
        }

        public void FirmalariGoruntule_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        public void AdminPaneli_Load(object sender, EventArgs e)
        {

        }

        private void firmaSilBtn_Click(object sender, EventArgs e)
        {

            string silinecekFirmaIsim = firmaSilText.Text;

            Firma silinecekFirma = firmalar.Find(firma => firma.FirmaIsim == silinecekFirmaIsim);

            if (silinecekFirma != null)
            {

                firmalar.Remove(silinecekFirma);


                FirmalariGoruntule.DataSource = null;
                FirmalariGoruntule.DataSource = firmalar;
                FirmalariGoruntule.DisplayMember = "FirmaIsim";
            }
            else
            {
                MessageBox.Show("Silinecek firma bulunamadı.");
            }

            firmaSilText.Clear();
        }

        private void hizmetbedelibuton_Click(object sender, EventArgs e)
        {
            Firma firma = new Firma();
            string hizmetbedeli=texthizmetbedeli.Text;
            MessageBox.Show("Hizmet bedeliniz " + hizmetbedeli + " TL olarak ayarlanmıştır.");
        }
    }
}
