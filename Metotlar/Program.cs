using System;

namespace Metotlar
{
    class program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Portakal";
            urun2.Fiyati = 17;
            urun2.Aciklama = "Yemeyen pişman";

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyati = 21;
            urun3.Aciklama = "Güzel armut";

            Urun[] urunler = new Urun[] {urun1, urun2, urun3};

            //type-safe tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " : " + urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine(" ");
            Console.WriteLine("---------Metotlar---------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
        }
    }
}