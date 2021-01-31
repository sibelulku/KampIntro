using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            // benim zaten toplama işlemini yapan metodum var. 
            //o metot DortIslem class'ının içerisinde olduğu için, bu class'tan bir örnek oluşturmam lazım.

            dortIslem.Topla(5, 6);  
            dortIslem.Topla(6, 9);
            // her sayfada farklı değerler toplayabilirsin. yani parametreler değişkenlik gösterebilir.
        }
    }
}
