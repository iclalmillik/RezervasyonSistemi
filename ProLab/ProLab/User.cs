using Prolab2_1.deneme;
using System;

namespace ProLab
{
    public abstract class User 
    {
        public string kullaniciAdi { get;  set; }
        public string sifre { get;  set; }

        public User(string kullaniciAdi, string sifre)
        {
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
        }

        public abstract void Login();
    }

    public class ConcreteClass : User
    {
        public ConcreteClass(string kullaniciAdi, string sifre) : base(kullaniciAdi, sifre)
        {
            kullaniciAdi = "a";
            sifre = "1";
        }
       
        public override void Login()
        {
            Console.WriteLine("kullanıcı girişi yapıldı.");
        }
    }
}
