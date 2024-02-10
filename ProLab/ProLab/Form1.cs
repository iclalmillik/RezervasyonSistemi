namespace ProLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adminPaneliGirisBtn_Click(object sender, EventArgs e)
        {
            string girilenKullaniciAdi = adminKullanýcýAdýText.Text;
            string sifre = adminSifreText.Text;
            ConcreteClass concreteClass = new ConcreteClass("a", "1");

            if (girilenKullaniciAdi == concreteClass.kullaniciAdi && sifre == concreteClass.sifre)
            {
                MessageBox.Show("Giriþ Baþarýlý");
                AdminPaneli adminPaneli = new AdminPaneli();
                adminPaneli.Show();

            }
            else
            {
                MessageBox.Show("Hatali Giriþ Lütfen Tekrar Deneyiniz");

            }
        }

        private void adminKullanýcýAdýText_TextChanged(object sender, EventArgs e)
        {
        }

        private void firmaGirisYap_Click(object sender, EventArgs e)
        {
            string girilenKullaniciAdi = firmaKullaniciAdiText.Text;
            string sifre = firmaSifreText.Text;
            ConcreteClass concreteClass = new ConcreteClass("b", "2");

            if (girilenKullaniciAdi == concreteClass.kullaniciAdi && sifre == concreteClass.sifre)
            {
                MessageBox.Show("Giriþ Baþarýlý");
                Arac firmaPaneli = new Arac();
                firmaPaneli.Show();

            }
            else
            {
                MessageBox.Show("Hatali Giriþ Lütfen Tekrar Deneyiniz");

            }
        }

        private void butonBiletAl_Click(object sender, EventArgs e)
        {
            KullaniciPaneli kullaniciPaneli=new KullaniciPaneli();
            kullaniciPaneli.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}