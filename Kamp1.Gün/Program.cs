using System;

namespace Kamp1.Gün
{
    class program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.69;
            bool sistemeGirisYapmisMi = true;

            //if (sistemeGirisYapmisMi == true)
            //{
            //    Console.WriteLine("Kullanıcı ayarları butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}

            //int sayi;

            //Console.WriteLine("Lütfen bir sayi degeri giriniz.");


            double dolarDun = 14.97;
            double dolarBugun = 14.97;

            if(dolarBugun > dolarDun)
            {
                Console.WriteLine("Yukarı yönlü ok");
            }
            else if(dolarBugun == dolarDun)
            {
                Console.WriteLine("Düz çizgi");
            }
            else
            {
                Console.WriteLine("Aşağı yönlü ok");
            }


        }
    }
}