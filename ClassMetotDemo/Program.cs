using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisteme Hoşgeldiniz!");
            Console.WriteLine("---------------------------!");

            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.firstName = "Ahmet";
            musteri1.lastName = "Demiryurek";
            musteri1.eMail = "ahmetdemiryurek@gmail.com";
            musteri1.password = "123123";

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.firstName = "Mevlüt";
            musteri2.lastName = "Demiryurek";
            musteri2.eMail = "mevlütdemiryurek@gmail.com";
            musteri2.password = "123123";

            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.firstName = "Rahime";
            musteri3.lastName = "Demiryurek";
            musteri3.eMail = "rahimedemiryurek@gmail.com";
            musteri3.password = "123123";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.firstName +" : "+ musteri.lastName);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);

        }
    }
}
