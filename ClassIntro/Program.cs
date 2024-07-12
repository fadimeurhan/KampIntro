using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "fadime";
            kurs1.IzlenmeOranı = 100;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "rıdvan";
            kurs2.IzlenmeOranı = 90;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "fatma";
            kurs3.IzlenmeOranı = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            kurs[] kurslar = new kurs[] { kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " = " + kurs.IzlenmeOranı + " Tamamlandı. ");
            }


        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }


}