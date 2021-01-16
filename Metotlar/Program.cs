using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Products urun1 = new Products();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Products urun2 = new Products();
            urun2.Adi = "Kapuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Products[] urunler = new Products[] {urun1, urun2};

            foreach (Products urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");

            }

            Console.WriteLine("-------------Metotlar------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 120);
        }
    }
}
