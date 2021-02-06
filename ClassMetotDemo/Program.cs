using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.TcNo = 12345;
            musteri1.Ad = "orkun";
            musteri1.Soyad = "erkuş";
            musteri1.Yas = 30;

            Musteri musteri2 = new Musteri();
            musteri2.TcNo = 54321;
            musteri2.Ad = "yagmur";
            musteri2.Soyad = "belinay";
            musteri2.Yas = 5;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle("ırmak" , "korkmaz" , 4 , 146321);
            musteriManager.MusteriListele(musteriler);
        }
    }
}
