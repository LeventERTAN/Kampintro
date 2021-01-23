using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteriler = new List<Musteri>();

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAd = "Levent";
            musteri1.MusteriSoyad = "Ertan";
            musteri1.TCKimlikNo = "1234567891";
            musteri1.MusteriTelefon = "5321234567";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAd = "Arman";
            musteri2.MusteriSoyad = "Ertan";
            musteri2.TCKimlikNo = "12345678911";
            musteri2.MusteriTelefon = "5321234567";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAd = "Zeren";
            musteri3.MusteriSoyad = "Ertan";
            musteri3.TCKimlikNo = "123456789111";
            musteri3.MusteriTelefon = "5321234567";

            musteriler.Add(musteri1);
            musteriler.Add(musteri2);
            musteriler.Add(musteri3);


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriListesi = musteriler;
            Console.WriteLine("-----------------Müşteri Listeleme-----------------------");
            musteriManager.musteriListele();

            Console.WriteLine("----------------------------Müşteri Ekleme-----------------------");
            Musteri musteri = new Musteri();

            Console.WriteLine("Müşteri Id'sini giriniz:");
            musteri1.MusteriId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Müşteri adını giriniz:");
            musteri1.MusteriAd = Console.ReadLine();

            Console.WriteLine("Müşteri soyadını giriniz:");
            musteri1.MusteriSoyad = Console.ReadLine();

            Console.WriteLine("Müşteri TC'sini giriniz:");
            musteri1.TCKimlikNo = Console.ReadLine();

            Console.WriteLine("Müşteri telefonunu giriniz:");
            musteri1.MusteriTelefon = Console.ReadLine();

            musteriManager.musteriEkle(musteri);

            Console.WriteLine("---------------------------------Müşteri Silme-----------------------");
            Console.WriteLine("Silmek istediğiniz müşterinin TC'sini giriniz:");
            string silinecekMusteriTC = Console.ReadLine();
            foreach (Musteri silinecekMusteri in musteriler)
            {
                if (silinecekMusteri.TCKimlikNo==silinecekMusteriTC)
                {
                    musteriManager.musteriSil(silinecekMusteri);
                    return;
                }
                else
                {
                    Console.WriteLine("Böyle bir müşteri kayıtlı değil");
                }
            }

        }
    }
}
