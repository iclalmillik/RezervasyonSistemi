using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab
{
    internal class Tren : Araclar
    {

        public Tren(string id, string yakit_turu, string yolcu_sayisi)
        {
            this.id = id;
            this.yakit_turu = yakit_turu;
            this.yolcu_sayisi = yolcu_sayisi;
        }

    }
}
