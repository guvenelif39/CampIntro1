using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "KeremVarış";
            kurs2.IzlenmeOranı = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOranı = 88;


            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni + " " + kurs1.IzlenmeOranı + "% tamamlandı");

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi)
            }
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
