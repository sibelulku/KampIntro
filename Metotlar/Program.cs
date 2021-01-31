using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Name = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Name = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Product[] urunler = new Product[] {urun1, urun2 };


            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("--------------Metotlar---------------------");

            SepetManager sepetManager = new SepetManager(); // class'ı çağırdım.
            sepetManager.Ekle(urun1); // SepetManager class'ım içerisindeki Ekle metodumu çağırdım.
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 8);   
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 10);

        }
    }
}
