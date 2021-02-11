using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] meyveler = new string[] { }; bunun içinde sadece string değerler tutabilirim.

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 40;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "armut";
            urun3.Fiyati = 20;
            urun3.Aciklama = "1. kalite armut";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun item in urunler)
            {
                Console.WriteLine("====>" + item.Adi);
                Console.WriteLine("====>" + item.Fiyati + "TL");
                Console.WriteLine("====>" + item.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("--------Metotlar---------");

            SepetManager sepetManager = new SepetManager(); // instance -örnek oluşturdum.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("armut", "yeşil armut", 12, 5);
            sepetManager.Ekle2("elma", "yeşil elma", 15, 3);
            sepetManager.Ekle2("karpuz", "diyarbakır armut", 20, 2);








            Console.ReadKey();

        }
    }
}
