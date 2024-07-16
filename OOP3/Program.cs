using System;
using System.Collections.Generic;
namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());
            basvuruManager.BasvuruYap(tasıtKrediManager , new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasıtKrediManager };

            //basvuruManager.KrediOnBilgilendirme(krediler);

        }
    }

}