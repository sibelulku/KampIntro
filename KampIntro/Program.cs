using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 0; i <= 30; i=i+2)
            {
                toplam = toplam + i;
                Console.WriteLine(toplam);
            }
                
        }
    }
}
