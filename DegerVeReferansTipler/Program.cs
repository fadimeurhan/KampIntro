using System;
namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            // sayı 1 değeri 10 iken sayı 2 ye eşitlendi ve 30 değerini aldı. sayı 2 ise 65 değerini aldı.


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            //2. listenin referans numarası 1. listeye eşitlendi. 2listesinin 0. indexi 999 olduğu için 1. listeninde 
            //0. indexi 999 oldu.





        }
    }
}