using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public Musteri AddMusteri(Musteri musteri)
        {
            Console.Write("Müşteri Id: ");
            musteri.MusteriId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Müşteri Adı ve Soyadı: ");
            musteri.MusteriAd = Console.ReadLine();
            Console.Write("Para Miktari: ");
            musteri.Balance =
        }


    }
}
