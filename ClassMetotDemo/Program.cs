using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ebru";
            musteri1.Soyad = "Gündeş";
            musteri1.Yas = 46;
            musteri1.Kart_Numarası = 12345645678;
            musteri1.Kart_CVC = 123;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Poyraz";
            musteri2.Soyad = "Karayel";
            musteri2.Yas = 29;
            musteri2.Kart_Numarası = 22345645679;
            musteri2.Kart_CVC = 223;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Emre";
            musteri3.Soyad = "Aydın";
            musteri3.Yas = 40;
            musteri3.Kart_Numarası = 32345645679;
            musteri3.Kart_CVC = 323;

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi+" "+musteri.Soyad+" "+musteri.Yas+" "+musteri.Kart_Numarası+" "+musteri.Kart_CVC);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

        }
    }
}
