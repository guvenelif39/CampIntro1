using System;

namespace CampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            // Don NOT repeat yourself
            // Değer tutucu, alias


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;


            if(dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
