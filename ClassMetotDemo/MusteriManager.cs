using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(string Ad, string Soyad, int Yas, int TcNo)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = Ad;
            musteri.Soyad = Soyad;
            musteri.Yas = Yas;
            musteri.TcNo = TcNo;
            Console.WriteLine("Müşteri Eklendi: " + Ad + " " + Soyad + " " + Yas + "" + TcNo);

        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine(musteri.TcNo);
            }
        }
    }
}
