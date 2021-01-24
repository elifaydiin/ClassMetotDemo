using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.MusteriAdi = "Elif";
            musteri1.MusteriSoyadi = "Aydın";
            musteri1.MusteriHesapNo = "123456789";
         

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.MusteriAdi = "Rümeysa";
            musteri2.MusteriSoyadi = "Usta";
            musteri2.MusteriHesapNo = "789456123";
          

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.MusteriAdi = "Meryem";
            musteri3.MusteriSoyadi = "Karakaş";
            musteri3.MusteriHesapNo = "056987123";
          

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.ID+". "+musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriSilme(musteri1);

            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriSilme(musteri2);

            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriListele(musteri3);
            musteriManager.MusteriSilme(musteri3);


        }
    }
}
