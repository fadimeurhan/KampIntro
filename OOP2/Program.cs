using System;
namespace OOP2
{
    class Program
    {
        static void Main(string[] arg)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adı = "fadime";
            musteri1.Soyadı = "urhan";
            musteri1.TcNo = "1234567";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "987654";
            musteri2.Id = 2;
            musteri2.VergiNo = "345798765";
            musteri2.SirketAdı = "FSR Tasımacılık";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



        }
    }
}