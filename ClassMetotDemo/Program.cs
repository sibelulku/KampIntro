using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.GovernmentId = "1234567890";
            customer1.FullName = "Sibel Ülkü";
            customer1.PrimaryPhone = "5425425252";
            customer1.PrimaryEmail = "sibel@test.com";
            customer1.NPSScore = 10;

            Musteri customer2 = new Musteri();
            customer2.GovernmentId = "1234567892";
            customer2.FullName = "Ziya Subaşı";
            customer2.PrimaryPhone = "5425422222";
            customer2.PrimaryEmail = "ziya@test.com";
            customer2.NPSScore = 6;

            Musteri[] customers = new Musteri[] { customer1, customer2 };  // müşteri array

            MusteriManager musteriManager = new MusteriManager(); // MusteriManager class çağrılır
            musteriManager.Ekle(customer1);
            musteriManager.Listele(customers);
            musteriManager.Sil(customer2);
            
        }
    }
}
