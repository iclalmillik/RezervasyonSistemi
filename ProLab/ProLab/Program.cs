using ProLab;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ProLab
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Firma firma = new Firma();

            List<Firma> Firmalar = new List<Firma>();




            Otobus otobus1 = new Otobus("1234", "Benzin", "20");
            Otobus otobus2 = new Otobus("7890", "Benzin", "15");
            Otobus otobus3 = new Otobus("2003", "Motorin", "15");
            Otobus otobus4 = new Otobus("2002", "Motorin", "20");
            Ucak ucak1 = new Ucak("2468", "Gaz", "30");
            Ucak ucak2 = new Ucak("1369", "Gaz", "30");
            Tren tren1 = new Tren("1010", "elektrik", "25");
            Tren tren2 = new Tren("2020", "elektrik", "25");
            Tren tren3 = new Tren("3030", "elektrik", "25");
            Ucak ucak3 = new Ucak("4040", "Gaz", "30");
            Ucak ucak4 = new Ucak("5050", "Gaz", "30");

            Firma FirmaA = new Firma("A Firmasi");
            Firma FirmaB = new Firma("B Firmasi");
            Firma FirmaC = new Firma("C Firmasi");
            Firma FirmaD = new Firma("D Firmasi");
            Firma FirmaF = new Firma("F Firmasi");

            Firmalar.Add(FirmaA);
            Firmalar.Add(FirmaB);
            Firmalar.Add(FirmaC);
            Firmalar.Add(FirmaD);
            Firmalar.Add(FirmaF);

            List<Araclar> tasit = new List<Araclar>();
            tasit.Add(otobus1);
            tasit.Add(otobus2);
            tasit.Add(otobus3);
            tasit.Add(tren1);
            tasit.Add(tren2);
            tasit.Add(tren3);
            tasit.Add(ucak1);
            tasit.Add(ucak2);
            tasit.Add(ucak3);
            Application.Run(new AdminPaneli(Firmalar));
            List<Seferler> SeferlerListesi = new List<Seferler>();
            SeferlerListesi.Add(new Seferler("1", "Demiryolu", "Ýstanbul", "Kocaeli", new DateTime(2023, 12, 3)));
            SeferlerListesi.Add(new Seferler("2", "Demiryolu", "Ýstanbul", "Bilecik", new DateTime(2023, 12, 4)));
            SeferlerListesi.Add(new Seferler("3", "Karayolu", "Ýstanbul", "Ankara", new DateTime(2023, 12, 5)));
            SeferlerListesi.Add(new Seferler("4", "Karayolu", "Ankara", "Ýstanbul", new DateTime(2023, 12, 6)));
            SeferlerListesi.Add(new Seferler("5", "Havayolu", "Ýstanbul", "Konya", new DateTime(2023, 12, 7)));
            SeferlerListesi.Add(new Seferler("6", "Havayolu", "Ýstanbul", "Ankara", new DateTime(2023, 12, 8)));
            Seferler seferler = new Seferler();


            Application.Run(new Arac(tasit, SeferlerListesi));


        }
    }
}