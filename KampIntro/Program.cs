using System;

namespace KampIntro
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYaptıMı = false;
            double dolardun = 7.35;
            double dolarBugun = 7.45;

            if (dolardun < dolarBugun)
            {
                Console.WriteLine("dolar yükseldi.");
            }
            else if (dolardun == dolarBugun)
            {
                Console.WriteLine("piyasa eşitlendi.");
            }
            else (dolardun > dolarBugun);
            {
                Console.WriteLine("dolar düştü");
            }
            if (sistemeGirisYaptıMı == true)
            {
                Console.WriteLine("başarılı");
            }
            else
            {
                Console.WriteLine("başarısız");


            }


            Console.WriteLine(KategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);

        }
    }
}