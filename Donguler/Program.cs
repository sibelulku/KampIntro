using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java", "Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); // kurslar array'inin i. elemanını ekrana yazdırır.
            }

            foreach (string kurs in kurslar) 
                // foreach : dizi temelli yapıları tek tek dönmeye yarar. kurslar'ı dolaş demek.
                // kurs : allias - takma isim
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("sayfa sonu - footer"); 
         
        }
    }
}
