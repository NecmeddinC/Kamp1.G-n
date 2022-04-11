using System;

namespace Donguler
{
    class program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Python", "Java", "Algoritma","Fizik","Matematik" };
            
            
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            //foreach dizileri tek tek dolaşmaya yarıyor.
            //for genel amaçlar için kullanılırken foreach dizileri daha kolay dolaşmak için kullanılır.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa sonuna geldiniz..");
        }
    }
}