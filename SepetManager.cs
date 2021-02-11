using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class SepetManager
    {
        public void Ekle(Urun urun)  // Urun tipinde urun ekledim.
        {
            Console.WriteLine("sepete eklendi." + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("sepete eklendi:" + urunAdi + aciklama + fiyat + stokAdedi);
        }
    }
}
