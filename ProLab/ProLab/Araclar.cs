using System;

namespace ProLab
{
    public abstract class Araclar
    {
        public string? id;
        public string? yakit_turu;
        public string? yolcu_sayisi;
      


        public Araclar(string id, string yakit_turu, string yolcu_sayisi)
        {
            this.id = id; ;
            this.yakit_turu = yakit_turu;
            this.yolcu_sayisi = yolcu_sayisi;
        }

        public Araclar(string yakit_turu, string yolcuSayisi)
        {
            this.yakit_turu = yakit_turu;
            this.yolcu_sayisi = yolcuSayisi;
        }

        public Araclar(string id)
        {
           this.id= id;
        }
        public Araclar()
        {
        }
        public override string ToString()
        {
            return $"ID: {id}, Yakıt Türü: {yakit_turu}, Yolcu Sayısı: {yolcu_sayisi}";
        }

        public class ConcreteClassA : Araclar
        {
            public ConcreteClassA(string id, string yakit_turu, string yolcu_sayisi)
                : base( id,yakit_turu,yolcu_sayisi)
            {
            }
            
        }
    }
}
