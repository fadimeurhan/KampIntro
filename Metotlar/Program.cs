using System;
namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya";

            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 45;
            urun2.Aciklama = "diyarbakır";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi + " : " + urun.Fiyati);
            }

            Console.WriteLine("--------Methotlar---------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);


            sepetmanager.Ekle2("armut", "yeşil armut", 15,13);
            sepetmanager.Ekle2("elma", "yeşil elma", 12,4);
            sepetmanager.Ekle2("karpuz", "diyarbakır karpuzu", 10,5);



             
        }
    }
}