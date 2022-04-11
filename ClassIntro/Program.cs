using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Necmeddin";
            kurs1.İzlenmeOrani = 87;

            //Kurs classında kurs1'i new kurs olarak tanımldık
            //Tanımladığımız kurs1'le Kurs classında tanımladığımız değişkenleri çağırdık.
            //kurs1 için gereken özellikleri kurs classı altında tutmuş olduk.

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Hüseyin";
            kurs2.İzlenmeOrani = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ahmet";
            kurs3.İzlenmeOrani = 57;

            //Alttaki satırda class içinde kurslar diye bi dizi tanımladık.
            //Tanımlanan kurslara ekleme yapmak için Nnew kurs dedik.
            //Oluşturduğum Kursu da bir dizi olarak ele aldık ve içine kurslar ekledik.

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            //foreach dizileri tek tek dolaşmaya yarıyor.
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int İzlenmeOrani { get; set; }

    }
}