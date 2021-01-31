using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product urun) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Name);
        }

        public void Ekle2(string urunName, string aciklama, double fiyat, int stokAdedi)   
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunName);
        }
    }
}
