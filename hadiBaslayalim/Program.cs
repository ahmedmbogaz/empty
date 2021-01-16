using System;

namespace hadiBaslayalim
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //do not repeat yourself = kendini tekrarlama

            string kategoriEtiketi = "kategori";
            int ogrencisayisi = 32000;
            double FaizOrani = 1.46;
            bool SistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (SistemeGirisYapmismi==true)
            {
                Console.WriteLine("Ayarlar");
            }
            else
            {
                Console.WriteLine("kategori");
            }


            Console.WriteLine(kategoriEtiketi);
        }
    }
}
