using System;

namespace ETicaretUrunClassOdevi
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun Urun1 = new Urun();
            Urun1.Fotograf = "1. Ürün Foto";
            Urun1.UrunAciklama = "ASUS X515JF Notebook";
            Urun1.Fiyat = 7269;
            Urun1.IndirimOrani = "%10";
            Urun1.IndirimliFiyat = 6179;

            Urun Urun2 = new Urun();
            Urun2.Fotograf = "2. Ürün Foto";
            Urun2.UrunAciklama = "Huawei Matebook D 14 Notebook";
            Urun2.Fiyat = 6998;
            Urun2.IndirimOrani = "%15";
            Urun2.IndirimliFiyat = 6299;

            Urun Urun3 = new Urun();
            Urun3.Fotograf = "3. Ürün Foto";
            Urun3.UrunAciklama = "ASUS F543NA Notebook";
            Urun3.Fiyat = 4351;
            Urun3.IndirimOrani = "%15";
            Urun3.IndirimliFiyat = 3699;

            Urun[] Urunler = new Urun[] { Urun1, Urun2, Urun3 };

            foreach (var Urun in Urunler)
            {
                Console.WriteLine(Urun.Fotograf);
                Console.WriteLine(Urun.UrunAciklama);
                Console.WriteLine(Urun.Fiyat);
                Console.WriteLine(Urun.IndirimOrani);
                Console.WriteLine(Urun.IndirimliFiyat);
            }

        }
    }
         class Urun
        {
            public string Fotograf { get; set; }
            public string UrunAciklama { get; set; }
            public float Fiyat { get; set; }
            public string IndirimOrani { get; set; }
            public float  IndirimliFiyat { get; set; }
        }



        
    
}

