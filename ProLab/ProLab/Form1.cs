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
            string girilenKullaniciAdi = adminKullan�c�Ad�Text.Text;
            string sifre = adminSifreText.Text;
            ConcreteClass concreteClass = new ConcreteClass("a", "1");

            if (girilenKullaniciAdi == concreteClass.kullaniciAdi && sifre == concreteClass.sifre)
            {
                MessageBox.Show("Giri� Ba�ar�l�");
                AdminPaneli adminPaneli = new AdminPaneli();
                adminPaneli.Show();

            }
            else
            {
                MessageBox.Show("Hatali Giri� L�tfen Tekrar Deneyiniz");

            }
        }

        private void adminKullan�c�Ad�Text_TextChanged(object sender, EventArgs e)
        {
        }

        private void firmaGirisYap_Click(object sender, EventArgs e)
        {
            string girilenKullaniciAdi = firmaKullaniciAdiText.Text;
            string sifre = firmaSifreText.Text;
            ConcreteClass concreteClass = new ConcreteClass("b", "2");

            if (girilenKullaniciAdi == concreteClass.kullaniciAdi && sifre == concreteClass.sifre)
            {
                MessageBox.Show("Giri� Ba�ar�l�");
                Arac firmaPaneli = new Arac();
                firmaPaneli.Show();

            }
            else
            {
                MessageBox.Show("Hatali Giri� L�tfen Tekrar Deneyiniz");

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