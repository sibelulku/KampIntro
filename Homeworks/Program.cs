using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1000;
            product1.Name = "Yıldız Baskılı Örme Pijama Takımı";
            product1.Color = "Mavi";
            product1.Size = "M";
            product1.Brand = "TrendyolMilla";

            Product product2 = new Product();
            product2.Id = 1001;
            product2.Name = "Panda Baskılı Örme Pijama Takımı";
            product2.Color = "Bordo";
            product2.Size = "M";
            product2.Brand = "Penti";

            Product product3 = new Product();
            product3.Id = 1002;
            product3.Name = "Yaprak Desenli Pijama Takımı";
            product3.Color = "Gri";
            product3.Size = "M";
            product3.Brand = "Oysho";

            Product product4 = new Product();
            product4.Id = 1003;
            product4.Name = "Çok Renkli Pijama Takımı";
            product4.Color = "Pembe";
            product4.Size = "M";
            product4.Brand = "İpekyol";

            Product[] urunler = new Product[] {product1, product2, product3, product4 };


            Console.WriteLine("-----For Loop-----");

            for (int i = 0; i < urunler.Length; i++)
            {
                //Console.WriteLine(urunler[i].Name);
                //Console.WriteLine("-----------");
                Console.WriteLine(urunler[i].Id + "\n" + urunler[i].Name + "\n" + urunler[i].Color + "\n" + urunler[i].Size + "\n" + urunler[i].Brand);
                Console.WriteLine("--------------");
            }


            Console.WriteLine("-----Foreach Loop-----");

            foreach (Product urun in urunler)
            {
                Console.WriteLine("Id : " + urun.Id);
                Console.WriteLine("Ad : " + urun.Name);
                Console.WriteLine("Renk : " + urun.Color);
                Console.WriteLine("Beden : " + urun.Size);
                Console.WriteLine("Marka : " + urun.Brand);
                Console.WriteLine("-----------");
            }


            Console.WriteLine("-----While Loop-----");

            int z = 0;
            while (z < urunler.Length)
            {
                Console.WriteLine(urunler[z].Brand);
                Console.WriteLine("-----------");

                z++;
            }

        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
    }

}
