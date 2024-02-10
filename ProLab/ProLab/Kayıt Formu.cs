using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab
{
    public partial class Kayıt_Formu : Form
    {
        public Kayıt_Formu()
        {
            InitializeComponent();
        }

        private void Kayıt_Formu_Load(object sender, EventArgs e)
        {

        }

        private void buttonTamam_Click(object sender, EventArgs e)
        {
            KullaniciPaneli.MusteriBilgileri.müsteriAdi = textBox1.Text + " " + textBox2.Text;
            //KullaniciPaneli f = new KullaniciPaneli();
            //f.müsteriAdi = textBox1.Text + " " + textBox2.Text;
            KullaniciPaneli.MusteriBilgileri.tc = textBox3.Text;
            if (radioButtonErkek.Checked == true)
                KullaniciPaneli.MusteriBilgileri.Cinsiyet = "Erkek";
            else
                KullaniciPaneli.MusteriBilgileri.Cinsiyet = "Kadın";
            MessageBox.Show("Kayıt Onaylandı.");
            this.Hide();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonKadın_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonErkek_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
