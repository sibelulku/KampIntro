using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; // sayi1, sayi2'ye atandı.
            sayi2 = 65;
            // sayi1 ?? (sayi1 değeri kaçtır?) --> 30

            // sayi1'in değeri sayi2'nin değerine eşittir.
            // sadece sayi2'nin değeri atanır / değer kopyalanır ve sayi2 ile olan irtibatı koparır.

            int[] sayilar1 = new int[] { 10, 20, 30 }; // adres 101 olsun.
            int[] sayilar2 = new int[] { 100, 200, 300}; // adres 102 olsun.
            sayilar1 = sayilar2;
            sayilar2[0] = 999; // sayilar2'nin ilk / 0. elamanı 999
            // sayilar1[0] ?? (sayilar1 array'in 0.elemanı kaçtır?) --> 999

            // new int --> new dediğin anda sayilar1 için heap'te yeni bir alan/adres oluşturulur ve değerleri oraya yazılır.
            // sayilar1 artık o adresi işaret eder. 

            // sayilar1 = sayilar2; demek sayilar1'in referans numarası artık sayilar2'nin referans numarasına / adresine eşittir demek.
            // artık sayilar1, sayilar2'nin adresindeki datayı okur. yani 102 adresindeki datayı okur -- pointer
            // artık 101 adresini tutan bişi yok, o yüzden .NET garbage collecter bir süre sonra bu alanı bellekten atar.


            // sayısal veri tipleri int, decimal, float, double, bool --> değer tip <--> bellek'te steak alanda tutulur.
            // array, class, interface --> referans tip <--> bellek'te heap alanda tutulur.

        }
    }
}
