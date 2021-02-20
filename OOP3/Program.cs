using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileBaseLoggerService = new FileBaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileBaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>()
            {ihtiyacKrediManager, konutKrediManager, tasitKrediManager }; //bankacı bir tanede seçebilir bir kaç tanede

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
