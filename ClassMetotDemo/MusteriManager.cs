using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {public List<Musteri> MusteriListesi { get; set; }
        public void musteriEkle(Musteri musteri)
        {
            MusteriListesi.Add(musteri);
        }

        public void musteriSil(Musteri musteri)
        {
            MusteriListesi.Remove(musteri);
        }

        public void musteriListele()
        {
            foreach (Musteri musteri in MusteriListesi)
            {
                Console.WriteLine(musteri.MusteriAd+" "+musteri.MusteriSoyad+" "+musteri.MusteriId+" "+musteri.TCKimlikNo+" "+musteri.MusteriTelefon);

                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            {

            }
        }



        //public Musteri AddMusteri(Musteri musteri)
        //{
        //    Console.Write("Müşteri Id: ");
        //    musteri.MusteriId = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Müşteri Adı ve Soyadı: ");
        //    musteri.MusteriAd = Console.ReadLine();
        //    Console.Write("Para Miktari: ");
        //    musteri.Balance =
        //}


    }
}
