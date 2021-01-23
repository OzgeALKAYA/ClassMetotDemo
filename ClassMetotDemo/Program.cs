using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Hanife ALKAYA";
            musteri1.KimlikNo = 11122233344;
            musteri1.Memleket = "Balıkesir";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Özge ALKAYA";
            musteri2.KimlikNo = 99988877744;
            musteri2.Memleket = "İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Anıl İNCE";
            musteri3.KimlikNo = 55566644422;
            musteri3.Memleket = "Gebze";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("İSİM-SOYİSİM" + ":" + musteri.Adi);
                
                Console.WriteLine("T.C." + ":" + musteri.KimlikNo);
              
                Console.WriteLine("Memleket" + ":" + musteri.Memleket);
                Console.WriteLine("-----------------------");
            }
            


                

            //Console.WriteLine("Hello World!");
        }
    }
}
