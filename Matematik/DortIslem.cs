using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2) 
        // parantez içerisindeki parametreler, metodunun ilgili işlemi yapabilmesi için ihtiyacı olan bilgilerdir.
        // toplama işlemi yapabilmem için en az iki sayı olması gerekiyor.
        {
            int toplam = sayi1 + sayi2;   // önce eşitliğin sağ tarafı çalışır. 
            Console.WriteLine("Sonuç : " + toplam);   // toplam'ı da string gibi algılayıp iki string ekrana yazdırıyormuş gibi davranır.
        }
    }
}
