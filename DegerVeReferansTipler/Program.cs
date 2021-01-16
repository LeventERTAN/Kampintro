using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2=65;
            //sayi1?? 30

            //int, decimal, float, double, bool = değer tip

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] 999

            //array, class,interface = referans tip

            //bellekte stack ve heap iki alan var  stack değertip, heap referanstip

            //stack sayi1=10    sayi2=30  değertiplerde sadece değer aktarılır ve sayi2 ile irtibat kopar

            //stack            heap
            //101/sayilar1      101/[10,20,30]
            //102/sayilar2      102/[100,200,300]

            // bu duruma pointer - gösterge denir

            //Değişken türleri:  "int", "long", "float", "double", "decimal", "char", "bool", "byte", "short", "struct", "enum"
            //Referans türleri:  "string", "object", "class", "interface", "array", "delegate", "pointer"
        }
    }
}
