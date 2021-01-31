using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri customer)
        {
            Console.WriteLine("Yeni müşteri kaydı oluşturuldu : " + customer.GovernmentId + "\n");
        }

        public void Listele(Musteri[] customers) // parametre olarak arrayi alıyorum
        {
            Console.WriteLine("----- Listele Metot Çağrısı : -----"  ); 
            Console.WriteLine("Müşteri Bilgileriniz : " + "\n");

            foreach (Musteri customer in customers)
            {
                Console.WriteLine("TCKN : " + customer.GovernmentId + "\n" +
                                  "Adı Soyadı : " + customer.FullName + "\n" +
                                  "Birincil Telefon Numarası : " + customer.PrimaryPhone + "\n" +
                                  "Birincil Email Adresi : " + customer.PrimaryEmail + "\n" +
                                  "NPS Score : " + customer.NPSScore);
                Console.WriteLine("------------------------------------------------------------");
            }
            Console.WriteLine("\n");
        }

        public void Sil(Musteri customer)
        {
            Console.WriteLine(customer.GovernmentId + " TCKN'li " + customer.FullName + " müşteri kaydı başarılı bir şekilde silinmiştir.");
        }

    }
}
