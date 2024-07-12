using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] 
                {"1.kurs",
                "2.kurs",
                "3.kurs" };  

            

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs); 
            }



            Console.WriteLine("sayfa sonu");
        }
    }
}